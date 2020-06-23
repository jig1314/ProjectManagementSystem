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
            var requirements = _context.Requirement.ToList();
            var requirementTypes = _context.RequirementTypes.ToList();
            var projectRequirements = requirements.Where(item => item.IdProject == idProject);
            var viewModels = projectRequirements.Select(item => new RequirementViewModel()
            {
                Id = item.Id,
                Requirement = item,
                RequirementType = requirementTypes.FirstOrDefault(type => type.Id == item.IdRequirementType)
            });

            return Json(viewModels.ToDataSourceResult(request));
        }
        public ActionResult Grid_PopupCreate(int idProject)
        {
            var viewModel = new RequirementViewModel()
            {
                Requirement = new Requirement()
                {
                    IdProject = idProject
                }
            };

            return PartialView("Grid_PopupCreate", viewModel);
        }

        public JsonResult DropDown_RequirementTypes()
        {
            var requirementTypes = _context.RequirementTypes.ToList();

            return Json(requirementTypes);
        }

        // POST: Requirements/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RequirementViewModel requirementViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(requirementViewModel.Requirement);
                await _context.SaveChangesAsync();

                var project = await _context.Project.FirstOrDefaultAsync(p => p.Id == requirementViewModel.Requirement.IdProject);
                return RedirectToAction("Edit", "Projects", project);
            }
            return Json(new { error = "The Requirement could not be added to this project!" });
        }

        public ActionResult Grid_PopupEdit(int idRequirement)
        {
            var requirement = _context.Requirement.FirstOrDefault(req => req.Id == idRequirement);
            var requirementType = _context.RequirementTypes.FirstOrDefault(type => type.Id == requirement.IdRequirementType);

            var viewModel = new RequirementViewModel()
            {
                Id = requirement.Id,
                Requirement = requirement,
                RequirementType = requirementType
            };

            return PartialView("Grid_PopupEdit", viewModel);
        }

        // POST: Requirements/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, RequirementViewModel requirementViewModel)
        {
            if (id != requirementViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(requirementViewModel.Requirement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequirementExists(requirementViewModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                var project = await _context.Project.FirstOrDefaultAsync(p => p.Id == requirementViewModel.Requirement.IdProject);
                return RedirectToAction("Edit", "Projects", project);
            }
            return Json(new { error = "The Requirement could not be updated!" });
        }

        [HttpDelete]
        public async Task<IActionResult> Grid_Destroy([DataSourceRequest] DataSourceRequest request, RequirementViewModel requirementViewModel)
        {
            if (requirementViewModel != null)
            {
                _context.Requirement.Remove(requirementViewModel.Requirement);
                await _context.SaveChangesAsync();
                return Json(new { success = "The Requirement deleted successfully!" });
            }

            return Json(new { error = "The Requirement could not be deleted!" });
        }

        private bool RequirementExists(int id)
        {
            return _context.Requirement.Any(e => e.Id == id);
        }

        #region Generated Methods

        //// GET: Requirements
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Requirement.ToListAsync());
        //}

        //// GET: Requirements/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var requirement = await _context.Requirement
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (requirement == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(requirement);
        //}

        //// GET: Requirements/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Requirements/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,RequirementName,Description,IdRequirementType")] Requirement requirement)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(requirement);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(requirement);
        //}

        //// GET: Requirements/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var requirement = await _context.Requirement.FindAsync(id);
        //    if (requirement == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(requirement);
        //}

        //// POST: Requirements/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,RequirementName,Description,IdRequirementType")] Requirement requirement)
        //{
        //    if (id != requirement.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(requirement);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!RequirementExists(requirement.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(requirement);
        //}

        //// GET: Requirements/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var requirement = await _context.Requirement
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (requirement == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(requirement);
        //}

        //// POST: Requirements/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var requirement = await _context.Requirement.FindAsync(id);
        //    _context.Requirement.Remove(requirement);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        #endregion
    }
}
