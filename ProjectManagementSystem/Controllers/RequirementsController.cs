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
using ProjectManagementSystem.ViewModels;

namespace ProjectManagementSystem.Controllers
{
    public class RequirementsController : Controller
    {
        private readonly ProjectContext _context;

        public RequirementsController(ProjectContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Grid_Read([DataSourceRequest] DataSourceRequest request, int idProject)
        {
            var viewModels = GetProjectRequirementViewModels(idProject);

            return Json(viewModels.ToDataSourceResult(request));
        }

        private IEnumerable<RequirementViewModel> GetProjectRequirementViewModels(int idProject)
        {
            var requirements = _context.Requirement.ToList();
            var requirementTypes = _context.RequirementTypes.ToList();
            var projectRequirements = requirements.Where(item => item.IdProject == idProject);
            var viewModels = projectRequirements.Select(item => new RequirementViewModel()
            {
                Id = item.Id,
                RequirementName = item.RequirementName,
                Description = item.Description,
                RequirementType = requirementTypes.FirstOrDefault(type => type.Id == item.IdRequirementType)
            });
            return viewModels;
        }

        [HttpPost]
        public async Task<IActionResult> Grid_Create([DataSourceRequest] DataSourceRequest request, int idProject, [Bind(Prefix = "models")] IEnumerable<RequirementViewModel> requirementViewModels)
        {
            foreach (var viewModel in requirementViewModels)
            {
                if (ModelState.IsValid)
                {
                    var requirement = new Requirement()
                    {
                        IdProject = idProject,
                        RequirementName = viewModel.RequirementName,
                        Description = viewModel.Description,
                        IdRequirementType = viewModel.RequirementType.Id
                    };
                    _context.Add(requirement);
                    await _context.SaveChangesAsync();
                }
            }
            
            var viewModels = GetProjectRequirementViewModels(idProject);

            return Json(viewModels.ToDataSourceResultAsync(request));
        }

        [HttpPut]
        public async Task<IActionResult> Grid_Update([DataSourceRequest] DataSourceRequest request, int idProject, [Bind(Prefix = "models")] IEnumerable<RequirementViewModel> requirementViewModels)
        {
            if (requirementViewModels != null && ModelState.IsValid)
            {
                foreach (var viewModel in requirementViewModels)
                {
                    try
                    {
                        var requirement = new Requirement()
                        {
                            Id = viewModel.Id,
                            IdProject = idProject,
                            RequirementName = viewModel.RequirementName,
                            Description = viewModel.Description,
                            IdRequirementType = viewModel.RequirementType.Id
                        };
                        _context.Update(requirement);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!RequirementExists(viewModel.Id))
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
            var viewModels = GetProjectRequirementViewModels(idProject);

            return Json(viewModels.ToDataSourceResultAsync(request));
        }

        [HttpDelete]
        public async Task<IActionResult> Grid_Destroy([DataSourceRequest] DataSourceRequest request, int idProject, [Bind(Prefix = "models")] IEnumerable<RequirementViewModel> requirementViewModels)
        {
            if (requirementViewModels != null)
            {
                var requirements = requirementViewModels.Select(viewModel => new Requirement()
                {
                    Id = viewModel.Id,
                    IdProject = idProject,
                    RequirementName = viewModel.RequirementName,
                    Description = viewModel.Description,
                    IdRequirementType = viewModel.RequirementType.Id
                });

                var requirementEfforts = _context.RequirementEffort.ToList();
                requirementEfforts = requirementEfforts.Join(requirements,
                    effort => effort.IdRequirement,
                    req => req.Id,
                    (effort, req) => effort).ToList();

                _context.RequirementEffort.RemoveRange(requirementEfforts);
                await _context.SaveChangesAsync();

                _context.Requirement.RemoveRange(requirements);
                await _context.SaveChangesAsync();
            }

            var viewModels = GetProjectRequirementViewModels(idProject);

            return Json(viewModels.ToDataSourceResultAsync(request));
        }

        private bool RequirementExists(int id)
        {
            return _context.Requirement.Any(e => e.Id == id);
        }
    }
}
