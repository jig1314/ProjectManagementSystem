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
    public class RequirementEffortsController : Controller
    {
        private readonly ProjectContext _context;

        public RequirementEffortsController(ProjectContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Grid_Read([DataSourceRequest] DataSourceRequest request, int idProject)
        {
            var viewModels = GetProjectRequirementEffortViewModels(idProject);

            return Json(viewModels.ToDataSourceResult(request));
        }

        private IEnumerable<RequirementEffortViewModel> GetProjectRequirementEffortViewModels(int idProject)
        {
            var requirementEffortTypes = _context.RequirementEffortTypes.ToList();
            var teamMembers = _context.TeamMember.ToList();
            var timeFrames = _context.TimeFrames.ToList();

            var requirements = _context.Requirement.ToList();
            var projectRequirementsIds = requirements.Where(r => r.IdProject == idProject).Select(req => req.Id);

            var requirementEfforts = _context.RequirementEffort.ToList();
            var projectRequirementEfforts = requirementEfforts.Join(projectRequirementsIds,
                effort => effort.IdRequirement,
                id => id,
                (effort, id) => effort);

            return projectRequirementEfforts.Select(effort => new RequirementEffortViewModel()
            {
                Id = effort.Id,
                RequirementEffort = effort,
                Requirement = requirements.FirstOrDefault(req => req.Id == effort.IdRequirement),
                RequirementEffortType = requirementEffortTypes.FirstOrDefault(type => type.Id == effort.IdRequirementEffortType),
                TeamMember = teamMembers.Where(mem => mem.Id == effort.IdTeamMember).Select(mem => new TeamMemberViewModel()
                {
                    Id = mem.Id, FirstName = mem.FirstName, LastName = mem.LastName
                }).FirstOrDefault(),
                TimeFrame = _context.TimeFrames.FirstOrDefault(frame => frame.Id == effort.IdTimeFrame),
                DateFrom = effort.DateFrom,
                DateTo = effort.DateTo,
                TimeExpended = effort.TimeExpended
            });
        }

        public ActionResult CreatePopUp(int idProject)
        {
            var requirements = _context.Requirement.ToList();
            ViewData["requirements"] = requirements.Where(r => r.IdProject == idProject);

            ViewData["requirementEffortTypes"] = _context.RequirementEffortTypes.ToList();

            var projectTeamMembers = _context.ProjectTeamMembers.ToList();
            var projectTeamMemberIds = projectTeamMembers.Where(item => item.IdProject == idProject).Select(item => item.IdTeamMember).ToList();

            var teamMembers = _context.TeamMember.ToList();
            teamMembers = teamMembers.Join(projectTeamMemberIds,
                mem => mem.Id,
                id => id,
                (mem, id) => mem).ToList();

            ViewData["teamMembers"] = teamMembers.Select(mem => new TeamMemberViewModel()
            {
                Id = mem.Id,
                FirstName = mem.FirstName,
                LastName = mem.LastName
            });

            ViewData["timeFrames"] = _context.TimeFrames.ToList();

            return PartialView();
        }

        public ActionResult EditPopUp(int idProject, int idRequirementEffort)
        {
            var requirements = _context.Requirement.ToList();
            ViewData["requirements"] = requirements.Where(r => r.IdProject == idProject);

            ViewData["requirementEffortTypes"] = _context.RequirementEffortTypes.ToList();

            var projectTeamMembers = _context.ProjectTeamMembers.ToList();
            var projectTeamMemberIds = projectTeamMembers.Where(item => item.IdProject == idProject).Select(item => item.IdTeamMember).ToList();

            var teamMembers = _context.TeamMember.ToList();
            teamMembers = teamMembers.Join(projectTeamMemberIds,
                mem => mem.Id,
                id => id,
                (mem, id) => mem).ToList();

            ViewData["teamMembers"] = teamMembers.Select(mem => new TeamMemberViewModel()
            {
                Id = mem.Id,
                FirstName = mem.FirstName,
                LastName = mem.LastName
            });

            ViewData["timeFrames"] = _context.TimeFrames.ToList();

            var requirementEffort = _context.RequirementEffort.FirstOrDefault(item => item.Id == idRequirementEffort);

            return PartialView(requirementEffort);
        }


        // POST: RequirementEfforts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task Create(RequirementEffort requirementEffort)
        {
            if (ModelState.IsValid)
            {
                _context.Add(requirementEffort);
                await _context.SaveChangesAsync();
            }
        }

        [HttpPut]
        [ValidateAntiForgeryToken]
        public async Task Edit(RequirementEffort requirementEffort)
        {
            if (ModelState.IsValid)
            {
                _context.Update(requirementEffort);
                await _context.SaveChangesAsync();
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Grid_Destroy([DataSourceRequest] DataSourceRequest request, int idProject, RequirementEffortViewModel requirementEffortViewModel)
        {
            _context.RemoveRange(requirementEffortViewModel.RequirementEffort);
            await _context.SaveChangesAsync();
            var viewModels = GetProjectRequirementEffortViewModels(idProject);

            return Json(viewModels.ToDataSourceResultAsync(request));
        }

        //// GET: RequirementEfforts/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var requirementEffort = await _context.RequirementEffort
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (requirementEffort == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(requirementEffort);
        //}

        //// GET: RequirementEfforts/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: RequirementEfforts/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,IdRequirement,IdTeamMember,IdRequirementEffortType,IdTimeFrame,DateFrom,DateTo,TimeExpended")] RequirementEffort requirementEffort)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(requirementEffort);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(requirementEffort);
        //}

        // GET: RequirementEfforts/Edit/5
        
        // POST: RequirementEfforts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,IdRequirement,IdTeamMember,IdRequirementEffortType,IdTimeFrame,DateFrom,DateTo,TimeExpended")] RequirementEffort requirementEffort)
        //{
        //    if (id != requirementEffort.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(requirementEffort);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!RequirementEffortExists(requirementEffort.Id))
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
        //    return View(requirementEffort);
        //}

        //// GET: RequirementEfforts/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var requirementEffort = await _context.RequirementEffort
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (requirementEffort == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(requirementEffort);
        //}

        //// POST: RequirementEfforts/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var requirementEffort = await _context.RequirementEffort.FindAsync(id);
        //    _context.RequirementEffort.Remove(requirementEffort);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool RequirementEffortExists(int id)
        {
            return _context.RequirementEffort.Any(e => e.Id == id);
        }
    }
}
