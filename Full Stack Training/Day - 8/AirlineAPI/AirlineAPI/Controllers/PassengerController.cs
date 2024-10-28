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
    public class PassengerController : ControllerBase
    {
        private readonly AirlinesApidbContext _context =new AirlinesApidbContext();

        //public PassengerController(AirlinesApidbContext context)
        //{
        //    _context = context;
        //}

        // GET: api/Passenger
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PassengerInfo>>> GetPassengerInfos()
        {
          if (_context.PassengerInfos == null)
          {
              return NotFound();
          }
            return await _context.PassengerInfos.ToListAsync();
        }

        // GET: api/Passenger/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PassengerInfo>> GetPassengerInfo(int id)
        {
          if (_context.PassengerInfos == null)
          {
              return NotFound();
          }
            var passengerInfo = await _context.PassengerInfos.FindAsync(id);

            if (passengerInfo == null)
            {
                return NotFound();
            }

            return passengerInfo;
        }

        // PUT: api/Passenger/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPassengerInfo(int id, PassengerInfo passengerInfo)
        {
            if (id != passengerInfo.PassengerId)
            {
                return BadRequest();
            }

            _context.Entry(passengerInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PassengerInfoExists(id))
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

        // POST: api/Passenger
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PassengerInfo>> PostPassengerInfo(PassengerInfo passengerInfo)
        {
          if (_context.PassengerInfos == null)
          {
              return Problem("Entity set 'AirlinesApidbContext.PassengerInfos'  is null.");
          }
            _context.PassengerInfos.Add(passengerInfo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PassengerInfoExists(passengerInfo.PassengerId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPassengerInfo", new { id = passengerInfo.PassengerId }, passengerInfo);
        }

        // DELETE: api/Passenger/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePassengerInfo(int id)
        {
            if (_context.PassengerInfos == null)
            {
                return NotFound();
            }
            var passengerInfo = await _context.PassengerInfos.FindAsync(id);
            if (passengerInfo == null)
            {
                return NotFound();
            }

            _context.PassengerInfos.Remove(passengerInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PassengerInfoExists(int id)
        {
            return (_context.PassengerInfos?.Any(e => e.PassengerId == id)).GetValueOrDefault();
        }
    }
}
