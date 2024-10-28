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
    public class ConsultancyServicesController : ControllerBase
    {
        private readonly EmcDbContext _context = new EmcDbContext();

        //public ConsultancyServicesController(EmcDbContext context)
        //{
        //    _context = context;
        //}

        // GET: api/ConsultancyServices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ConsultancyService>>> GetConsultancyServices()
        {
          if (_context.ConsultancyServices == null)
          {
              return NotFound();
          }
            return await _context.ConsultancyServices.ToListAsync();
        }

        // GET: api/ConsultancyServices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ConsultancyService>> GetConsultancyService(int id)
        {
          if (_context.ConsultancyServices == null)
          {
              return NotFound();
          }
            var consultancyService = await _context.ConsultancyServices.FindAsync(id);

            if (consultancyService == null)
            {
                return NotFound();
            }

            return consultancyService;
        }

        // PUT: api/ConsultancyServices/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsultancyService(int id, ConsultancyService consultancyService)
        {
            if (id != consultancyService.ServiceId)
            {
                return BadRequest();
            }

            _context.Entry(consultancyService).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConsultancyServiceExists(id))
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

        // POST: api/ConsultancyServices
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ConsultancyService>> PostConsultancyService(ConsultancyService consultancyService)
        {
          if (_context.ConsultancyServices == null)
          {
              return Problem("Entity set 'EmcDbContext.ConsultancyServices'  is null.");
          }
            _context.ConsultancyServices.Add(consultancyService);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConsultancyService", new { id = consultancyService.ServiceId }, consultancyService);
        }

        // DELETE: api/ConsultancyServices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsultancyService(int id)
        {
            if (_context.ConsultancyServices == null)
            {
                return NotFound();
            }
            var consultancyService = await _context.ConsultancyServices.FindAsync(id);
            if (consultancyService == null)
            {
                return NotFound();
            }

            _context.ConsultancyServices.Remove(consultancyService);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ConsultancyServiceExists(int id)
        {
            return (_context.ConsultancyServices?.Any(e => e.ServiceId == id)).GetValueOrDefault();
        }
    }
}
