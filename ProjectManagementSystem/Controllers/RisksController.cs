using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectManagementSystem.Data;
using ProjectManagementSystem.Models;

namespace ProjectManagementSystem.Controllers
{
    public class RisksController : Controller
    {
        private readonly ProjectContext _context;

        public RisksController(ProjectContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public ActionResult Grid_Read([DataSourceRequest] DataSourceRequest request, int idProject)
        {
            var projectRisks = GetProjectRisks(idProject).Result;

            return Json(projectRisks.ToDataSourceResult(request));
        }

        private async Task<IEnumerable<Risk>> GetProjectRisks(int idProject)
        {
            var projectRisks = await _context.ProjectRisks.ToListAsync();

            var projectRiskIds = projectRisks.Where(item => item.IdProject == idProject).Select(item => item.IdRisk).ToList();

            var teamRisks = await _context.Risk.ToListAsync();

            return teamRisks.Join(projectRiskIds,
                mem => mem.Id,
                proj => proj,
                (mem, proj) => mem).ToList();
        }

        [HttpPost]
        public async Task<IActionResult> Grid_Create([DataSourceRequest] DataSourceRequest request, int idProject, [Bind(Prefix = "models")] IEnumerable<Risk> risks)
        {
            var project = await _context.Project
                .FirstOrDefaultAsync(m => m.Id == idProject);

            foreach (var risk in risks)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(risk);
                    await _context.SaveChangesAsync();

                    _context.Add(new Project_Risk()
                    {
                        IdProject = idProject,
                        IdRisk = risk.Id
                    });
                    await _context.SaveChangesAsync();
                }
            }

            var projectRisks = await GetProjectRisks(idProject);

            return Json(projectRisks.ToDataSourceResultAsync(request, ModelState));
        }

        [HttpPut]
        public async Task<IActionResult> Grid_Update([DataSourceRequest] DataSourceRequest request, int idProject, [Bind(Prefix = "models")] IEnumerable<Risk> risks)
        {
            if (risks != null && ModelState.IsValid)
            {
                foreach (var risk in risks)
                {
                    if (ModelState.IsValid)
                    {
                        try
                        {
                            _context.Update(risk);
                            await _context.SaveChangesAsync();
                        }
                        catch (DbUpdateConcurrencyException)
                        {
                            if (!RiskExists(risk.Id))
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

            var projectRisks = await GetProjectRisks(idProject);

            return Json(projectRisks.ToDataSourceResultAsync(request, ModelState));
        }


        [HttpDelete]
        public async Task<IActionResult> Grid_Destroy([DataSourceRequest] DataSourceRequest request, int idProject, [Bind(Prefix = "models")] IEnumerable<Risk> risks)
        {
            if (risks != null && risks.Any())
            {
                foreach (var risk in risks)
                {
                    var projectRiskMappings = await _context.ProjectRisks.ToListAsync();
                    projectRiskMappings = projectRiskMappings.Where(item => item.IdRisk == risk.Id).ToList();

                    _context.ProjectRisks.RemoveRange(projectRiskMappings);
                    await _context.SaveChangesAsync();

                    _context.Risk.Remove(risk);
                    await _context.SaveChangesAsync();
                }
            }

            var projectRisks = await GetProjectRisks(idProject);

            return Json(projectRisks.ToDataSourceResultAsync(request, ModelState));
        }

        private bool RiskExists(int id)
        {
            return _context.Risk.Any(e => e.Id == id);
        }
    }
}
