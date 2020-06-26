using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectManagementSystem.Data;
using ProjectManagementSystem.Models;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;

namespace ProjectManagementSystem.Controllers
{
    public class TeamMembersController : Controller
    {
        private readonly ProjectContext _context;

        public TeamMembersController(ProjectContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Grid_Read([DataSourceRequest] DataSourceRequest request, int idProject)
        {
            var projectTeamMembers = GetProjectTeamMembers(idProject).Result;

            return Json(projectTeamMembers.ToDataSourceResult(request));
        }

        private async Task<IEnumerable<TeamMember>> GetProjectTeamMembers(int idProject)
        {
            var projectTeamMembers = await _context.ProjectTeamMembers.ToListAsync();

            var projectTeamMembersIds = projectTeamMembers.Where(item => item.IdProject == idProject).Select(item => item.IdTeamMember).ToList();

            var teamMembers = await _context.TeamMember.ToListAsync();

            return teamMembers.Join(projectTeamMembersIds,
                mem => mem.Id,
                proj => proj,
                (mem, proj) => mem).ToList(); 
        }

        [HttpPost]
        public async Task<IActionResult> Grid_Create([DataSourceRequest] DataSourceRequest request, int idProject, [Bind(Prefix = "models")] IEnumerable<TeamMember> teamMembers)
        {
            var project = await _context.Project
                .FirstOrDefaultAsync(m => m.Id == idProject);

            foreach (var teamMember in teamMembers)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(teamMember);
                    await _context.SaveChangesAsync();

                    _context.Add(new Project_TeamMember()
                    {
                        IdProject = idProject,
                        IdTeamMember = teamMember.Id
                    });
                    await _context.SaveChangesAsync();
                }
            }

            var projectTeamMembers = await GetProjectTeamMembers(idProject);

            return Json(projectTeamMembers.ToDataSourceResultAsync(request, ModelState));
        }

        [HttpPut]
        public async Task<IActionResult> Grid_Update([DataSourceRequest] DataSourceRequest request, int idProject, [Bind(Prefix = "models")] IEnumerable<TeamMember> teamMembers)
        {
            if (teamMembers != null && ModelState.IsValid)
            {
                foreach (var teamMember in teamMembers)
                {
                    if (ModelState.IsValid)
                    {
                        try
                        {
                            _context.Update(teamMember);
                            await _context.SaveChangesAsync();
                        }
                        catch (DbUpdateConcurrencyException)
                        {
                            if (!TeamMemberExists(teamMember.Id))
                            {
                                return NotFound();
                            }
                            else
                            {
                                throw;
                            }
                        }
                    }
                }
            }

            var projectTeamMembers = await GetProjectTeamMembers(idProject);

            return Json(projectTeamMembers.ToDataSourceResultAsync(request, ModelState));
        }

        [HttpDelete]
        public async Task<IActionResult> Grid_Destroy([DataSourceRequest] DataSourceRequest request, int idProject, [Bind(Prefix = "models")] IEnumerable<TeamMember> teamMembers)
        {
            if (teamMembers != null && teamMembers.Any())
            {
                foreach (var teamMember in teamMembers)
                {
                    var requirementEfforts = await _context.RequirementEffort.ToListAsync();
                    requirementEfforts = requirementEfforts.Where(req => req.IdTeamMember == teamMember.Id).ToList();

                    var projectMemberships = await _context.ProjectTeamMembers.ToListAsync();
                    projectMemberships = projectMemberships.Where(item => item.IdTeamMember == teamMember.Id).ToList();

                    _context.RequirementEffort.RemoveRange(requirementEfforts);
                    await _context.SaveChangesAsync();

                    _context.ProjectTeamMembers.RemoveRange(projectMemberships);
                    await _context.SaveChangesAsync();

                    _context.TeamMember.Remove(teamMember);
                    await _context.SaveChangesAsync();
                }
            }

            var projectTeamMembers = await GetProjectTeamMembers(idProject);

            return Json(projectTeamMembers.ToDataSourceResultAsync(request, ModelState));
        }

        private bool TeamMemberExists(int id)
        {
            return _context.TeamMember.Any(e => e.Id == id);
        }
    }
}
