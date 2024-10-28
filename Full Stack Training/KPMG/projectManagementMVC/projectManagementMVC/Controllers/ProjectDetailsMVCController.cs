using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using projectManagementMVC.Models;

namespace projectManagementMVC.Controllers
{
    public class ProjectDetailsMVCController : Controller
    {
        private readonly ProjectManagementContext _context = new ProjectManagementContext();

        //public ProjectDetailsMVCController(ProjectManagementContext context)
        //{
        //    _context = context;
        //}

        // GET: ProjectDetailsMVC
        public async Task<IActionResult> Index()
        {
              return _context.ProjectDetails != null ? 
                          View(await _context.ProjectDetails.ToListAsync()) :
                          Problem("Entity set 'ProjectManagementContext.ProjectDetails'  is null.");
        }

        // GET: ProjectDetailsMVC/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProjectDetails == null)
            {
                return NotFound();
            }

            var projectDetail = await _context.ProjectDetails
                .FirstOrDefaultAsync(m => m.ProjectId == id);
            if (projectDetail == null)
            {
                return NotFound();
            }

            return View(projectDetail);
        }

        // GET: ProjectDetailsMVC/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProjectDetailsMVC/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectId,ProjectName,ProjectDomain,ProjectHead,ProjectLead,ProjectPrice,ProjectStatus")] ProjectDetail projectDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projectDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projectDetail);
        }

        // GET: ProjectDetailsMVC/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProjectDetails == null)
            {
                return NotFound();
            }

            var projectDetail = await _context.ProjectDetails.FindAsync(id);
            if (projectDetail == null)
            {
                return NotFound();
            }
            return View(projectDetail);
        }

        // POST: ProjectDetailsMVC/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectId,ProjectName,ProjectDomain,ProjectHead,ProjectLead,ProjectPrice,ProjectStatus")] ProjectDetail projectDetail)
        {
            if (id != projectDetail.ProjectId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectDetailExists(projectDetail.ProjectId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(projectDetail);
        }

        // GET: ProjectDetailsMVC/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProjectDetails == null)
            {
                return NotFound();
            }

            var projectDetail = await _context.ProjectDetails
                .FirstOrDefaultAsync(m => m.ProjectId == id);
            if (projectDetail == null)
            {
                return NotFound();
            }

            return View(projectDetail);
        }

        // POST: ProjectDetailsMVC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProjectDetails == null)
            {
                return Problem("Entity set 'ProjectManagementContext.ProjectDetails'  is null.");
            }
            var projectDetail = await _context.ProjectDetails.FindAsync(id);
            if (projectDetail != null)
            {
                _context.ProjectDetails.Remove(projectDetail);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectDetailExists(int id)
        {
          return (_context.ProjectDetails?.Any(e => e.ProjectId == id)).GetValueOrDefault();
        }
    }
}
