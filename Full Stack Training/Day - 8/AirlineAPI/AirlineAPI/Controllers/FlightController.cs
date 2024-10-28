using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AirlineAPI.Models;

namespace AirlineAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly AirlinesApidbContext _context = new AirlinesApidbContext();

        //public FlightController(AirlinesApidbContext context)
        //{
        //    _context = context;
        //}

        // GET: api/Flight
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FlightScheduleInfo>>> GetFlightScheduleInfos()
        {
          if (_context.FlightScheduleInfos == null)
          {
              return NotFound();
          }
            return await _context.FlightScheduleInfos.ToListAsync();
        }

        // GET: api/Flight/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FlightScheduleInfo>> GetFlightScheduleInfo(int id)
        {
          if (_context.FlightScheduleInfos == null)
          {
              return NotFound();
          }
            var flightScheduleInfo = await _context.FlightScheduleInfos.FindAsync(id);

            if (flightScheduleInfo == null)
            {
                return NotFound();
            }

            return flightScheduleInfo;
        }

        // PUT: api/Flight/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlightScheduleInfo(int id, FlightScheduleInfo flightScheduleInfo)
        {
            if (id != flightScheduleInfo.FightId)
            {
                return BadRequest();
            }

            _context.Entry(flightScheduleInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FlightScheduleInfoExists(id))
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

        // POST: api/Flight
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FlightScheduleInfo>> PostFlightScheduleInfo(FlightScheduleInfo flightScheduleInfo)
        {
          if (_context.FlightScheduleInfos == null)
          {
              return Problem("Entity set 'AirlinesApidbContext.FlightScheduleInfos'  is null.");
          }
            _context.FlightScheduleInfos.Add(flightScheduleInfo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FlightScheduleInfoExists(flightScheduleInfo.FightId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFlightScheduleInfo", new { id = flightScheduleInfo.FightId }, flightScheduleInfo);
        }

        // DELETE: api/Flight/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFlightScheduleInfo(int id)
        {
            if (_context.FlightScheduleInfos == null)
            {
                return NotFound();
            }
            var flightScheduleInfo = await _context.FlightScheduleInfos.FindAsync(id);
            if (flightScheduleInfo == null)
            {
                return NotFound();
            }

            _context.FlightScheduleInfos.Remove(flightScheduleInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FlightScheduleInfoExists(int id)
        {
            return (_context.FlightScheduleInfos?.Any(e => e.FightId == id)).GetValueOrDefault();
        }
    }
}
