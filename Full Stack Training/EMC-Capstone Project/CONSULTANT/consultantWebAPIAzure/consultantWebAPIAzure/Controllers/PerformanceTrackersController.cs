using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using consultantWebAPIAzure.Models;

namespace consultantWebAPIAzure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerformanceTrackersController : ControllerBase
    {
        private readonly EmcDbContext _context = new EmcDbContext();

        //public PerformanceTrackersController(EmcDbContext context)
        //{
        //    _context = context;
        //}

        // GET: api/PerformanceTrackers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PerformanceTracker>>> GetPerformanceTrackers()
        {
          if (_context.PerformanceTrackers == null)
          {
              return NotFound();
          }
            return await _context.PerformanceTrackers.ToListAsync();
        }

        // GET: api/PerformanceTrackers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PerformanceTracker>> GetPerformanceTracker(int id)
        {
          if (_context.PerformanceTrackers == null)
          {
              return NotFound();
          }
            var performanceTracker = await _context.PerformanceTrackers.FindAsync(id);

            if (performanceTracker == null)
            {
                return NotFound();
            }

            return performanceTracker;
        }

        // PUT: api/PerformanceTrackers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerformanceTracker(int id, PerformanceTracker performanceTracker)
        {
            if (id != performanceTracker.TrackerId)
            {
                return BadRequest();
            }

            _context.Entry(performanceTracker).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PerformanceTrackerExists(id))
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

        // POST: api/PerformanceTrackers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PerformanceTracker>> PostPerformanceTracker(PerformanceTracker performanceTracker)
        {
          if (_context.PerformanceTrackers == null)
          {
              return Problem("Entity set 'EmcDbContext.PerformanceTrackers'  is null.");
          }
            _context.PerformanceTrackers.Add(performanceTracker);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPerformanceTracker", new { id = performanceTracker.TrackerId }, performanceTracker);
        }

        // DELETE: api/PerformanceTrackers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerformanceTracker(int id)
        {
            if (_context.PerformanceTrackers == null)
            {
                return NotFound();
            }
            var performanceTracker = await _context.PerformanceTrackers.FindAsync(id);
            if (performanceTracker == null)
            {
                return NotFound();
            }

            _context.PerformanceTrackers.Remove(performanceTracker);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PerformanceTrackerExists(int id)
        {
            return (_context.PerformanceTrackers?.Any(e => e.TrackerId == id)).GetValueOrDefault();
        }
    }
}
