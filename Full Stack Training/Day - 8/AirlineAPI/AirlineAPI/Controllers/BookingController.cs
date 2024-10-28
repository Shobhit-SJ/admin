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
    public class BookingController : ControllerBase
    {
        private readonly AirlinesApidbContext _context = new AirlinesApidbContext();

        //public BookingController(AirlinesApidbContext context)
        //{
        //    _context = context;
        //}

        // GET: api/Booking
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookingInfo>>> GetBookingInfos()
        {
          if (_context.BookingInfos == null)
          {
              return NotFound();
          }
            return await _context.BookingInfos.ToListAsync();
        }

        // GET: api/Booking/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookingInfo>> GetBookingInfo(int id)
        {
          if (_context.BookingInfos == null)
          {
              return NotFound();
          }
            var bookingInfo = await _context.BookingInfos.FindAsync(id);

            if (bookingInfo == null)
            {
                return NotFound();
            }

            return bookingInfo;
        }

        // PUT: api/Booking/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBookingInfo(int id, BookingInfo bookingInfo)
        {
            if (id != bookingInfo.Pnrno)
            {
                return BadRequest();
            }

            _context.Entry(bookingInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookingInfoExists(id))
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

        // POST: api/Booking
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BookingInfo>> PostBookingInfo(BookingInfo bookingInfo)
        {
          if (_context.BookingInfos == null)
          {
              return Problem("Entity set 'AirlinesApidbContext.BookingInfos'  is null.");
          }
            _context.BookingInfos.Add(bookingInfo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BookingInfoExists(bookingInfo.Pnrno))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBookingInfo", new { id = bookingInfo.Pnrno }, bookingInfo);
        }

        // DELETE: api/Booking/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookingInfo(int id)
        {
            if (_context.BookingInfos == null)
            {
                return NotFound();
            }
            var bookingInfo = await _context.BookingInfos.FindAsync(id);
            if (bookingInfo == null)
            {
                return NotFound();
            }

            _context.BookingInfos.Remove(bookingInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BookingInfoExists(int id)
        {
            return (_context.BookingInfos?.Any(e => e.Pnrno == id)).GetValueOrDefault();
        }
    }
}
