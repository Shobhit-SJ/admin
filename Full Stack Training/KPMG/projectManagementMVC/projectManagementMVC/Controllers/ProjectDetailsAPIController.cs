using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projectManagementMVC.Models;

namespace projectManagementMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectDetailsAPIController : ControllerBase
    {
        private readonly ProjectManagementContext _context = new ProjectManagementContext();

        //public ProjectDetailsAPIController(ProjectManagementContext context)
        //{
        //    _context = context;
        //}

        // GET: api/ProjectDetailsAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProjectDetail>>> GetProjectDetails()
        {
          if (_context.ProjectDetails == null)
          {
              return NotFound();
          }
            return await _context.ProjectDetails.ToListAsync();
        }

        // GET: api/ProjectDetailsAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectDetail>> GetProjectDetail(int id)
        {
          if (_context.ProjectDetails == null)
          {
              return NotFound();
          }
            var projectDetail = await _context.ProjectDetails.FindAsync(id);

            if (projectDetail == null)
            {
                return NotFound();
            }

            return projectDetail;
        }

        // PUT: api/ProjectDetailsAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProjectDetail(int id, ProjectDetail projectDetail)
        {
            if (id != projectDetail.ProjectId)
            {
                return BadRequest();
            }

            _context.Entry(projectDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ProjectDetailsAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProjectDetail>> PostProjectDetail(ProjectDetail projectDetail)
        {
          if (_context.ProjectDetails == null)
          {
              return Problem("Entity set 'ProjectManagementContext.ProjectDetails'  is null.");
          }
            _context.ProjectDetails.Add(projectDetail);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProjectDetailExists(projectDetail.ProjectId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProjectDetail", new { id = projectDetail.ProjectId }, projectDetail);
        }

        // DELETE: api/ProjectDetailsAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProjectDetail(int id)
        {
            if (_context.ProjectDetails == null)
            {
                return NotFound();
            }
            var projectDetail = await _context.ProjectDetails.FindAsync(id);
            if (projectDetail == null)
            {
                return NotFound();
            }

            _context.ProjectDetails.Remove(projectDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProjectDetailExists(int id)
        {
            return (_context.ProjectDetails?.Any(e => e.ProjectId == id)).GetValueOrDefault();
        }
    }
}
