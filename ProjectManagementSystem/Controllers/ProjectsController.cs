using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectManagementSystem.Data;
using ProjectManagementSystem.Models;
using ProjectManagementSystem.ViewModels;

namespace ProjectManagementSystem.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly ProjectContext _context;

        public ProjectsController(ProjectContext context)
        {
            _context = context;
        }

        // GET: Projects
        public async Task<IActionResult> Index()
        {
            return View(await _context.Project.ToListAsync());
        }

        // GET: Projects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Project
                .FirstOrDefaultAsync(m => m.Id == id);

            var viewModel = new ProjectDetailsViewModel();

            if (project == null)
            {
                return NotFound();
            }
            else
            {
                viewModel = new ProjectDetailsViewModel()
                {
                    Id = project.Id,
                    Description = project.Description,
                    Name = project.Name,
                    OwnerName = project.OwnerName,
                    TeamMembers = await GetProjectTeamMembers(id),
                    Risks = await GetProjectRisks(id)
                };

            }

            return View(viewModel);
        }

        public async Task<List<TeamMember>> GetProjectTeamMembers(int? idProject)
        {
            var projectTeamMembers = await _context.ProjectTeamMembers.ToListAsync();
            var projectTeamMemberIds = projectTeamMembers.Where(item => item.IdProject == idProject).Select(item => item.IdTeamMember).ToList();

            var teamMembers = await _context.TeamMember.ToListAsync();
            return teamMembers.Join(projectTeamMemberIds,
                mem => mem.Id,
                id => id,
                (mem, id) => mem).ToList();
        }

        public async Task<List<Risk>> GetProjectRisks(int? idProject)
        {
            var projectRisks = await _context.ProjectRisks.ToListAsync();
            var projectRiskIds = projectRisks.Where(item => item.IdProject == idProject).Select(item => item.IdRisk).ToList();

            var risks = await _context.Risk.ToListAsync();

            return risks.Join(projectRiskIds,
                risk => risk.Id,
                id => id,
                (risk, id) => risk).ToList();
        }

        // GET: Projects/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,OwnerName")] Project project)
        {
            if (ModelState.IsValid)
            {
                _context.Add(project);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Edit), project);
            }
            return View(project);
        }

        // GET: Projects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Project.FindAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,OwnerName")] Project project)
        {
            if (id != project.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(project);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectExists(project.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return View(project);
        }

        // GET: Projects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Project
                .FirstOrDefaultAsync(m => m.Id == id);
            var viewModel = new ProjectDetailsViewModel();

            if (project == null)
            {
                return NotFound();
            }
            else
            {
                viewModel = new ProjectDetailsViewModel()
                {
                    Id = project.Id,
                    Description = project.Description,
                    Name = project.Name,
                    OwnerName = project.OwnerName,
                    TeamMembers = await GetProjectTeamMembers(id),
                    Risks = await GetProjectRisks(id)
                };

            }

            return View(viewModel);
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var project = await _context.Project.FindAsync(id);

            var projectTeamMembers = await _context.ProjectTeamMembers.ToListAsync();
            projectTeamMembers = projectTeamMembers.Where(item => item.IdProject == id).ToList();
            var projectTeamMemberIds = projectTeamMembers.Select(item => item.IdTeamMember).ToList();

            var teamMembers = await _context.TeamMember.ToListAsync();
            teamMembers = teamMembers.Join(projectTeamMemberIds,
                mem => mem.Id,
                proj => proj,
                (mem, proj) => mem).ToList();

            var projectRisks = await _context.ProjectRisks.ToListAsync();
            projectRisks = projectRisks.Where(item => item.IdProject == id).ToList();
            var projectRiskIds = projectRisks.Select(item => item.IdRisk).ToList();

            var risks = await _context.Risk.ToListAsync();

            risks = risks.Join(projectRiskIds,
                risk => risk.Id,
                id => id,
                (risk, id) => risk).ToList();

            _context.ProjectTeamMembers.RemoveRange(projectTeamMembers);
            await _context.SaveChangesAsync();

            _context.TeamMember.RemoveRange(teamMembers);
            await _context.SaveChangesAsync();

            _context.ProjectRisks.RemoveRange(projectRisks);
            await _context.SaveChangesAsync();

            _context.Risk.RemoveRange(risks);
            await _context.SaveChangesAsync();

            _context.Project.Remove(project);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool ProjectExists(int id)
        {
            return _context.Project.Any(e => e.Id == id);
        }
    }
}
