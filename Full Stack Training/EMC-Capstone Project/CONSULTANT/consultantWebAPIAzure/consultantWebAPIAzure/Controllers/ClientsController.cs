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
    public class ClientsController : ControllerBase
    {
        private readonly EmcDbContext _context = new EmcDbContext();

        //public ClientsController(EmcDbContext context)
        //{
        //    _context = context;
        //}

        // GET: api/Clients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> GetClients()
        {
          if (_context.Clients == null)
          {
              return NotFound();
          }
            return await _context.Clients.ToListAsync();
        }

        // GET: api/Clients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> GetClient(int id)
        {
          if (_context.Clients == null)
          {
              return NotFound();
          }
            var client = await _context.Clients.FindAsync(id);

            if (client == null)
            {
                return NotFound();
            }

            return client;
        }

        // PUT: api/Clients/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClient(int id, Client client)
        {
            if (id != client.ClientId)
            {
                return BadRequest();
            }

            _context.Entry(client).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientExists(id))
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

        // POST: api/Clients
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Client>> PostClient(Client client)
        {
          if (_context.Clients == null)
          {
              return Problem("Entity set 'EmcDbContext.Clients'  is null.");
          }
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClient", new { id = client.ClientId }, client);
        }

        // DELETE: api/Clients/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            if (_context.Clients == null)
            {
                return NotFound();
            }
            var client = await _context.Clients.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }

            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClientExists(int id)
        {
            return (_context.Clients?.Any(e => e.ClientId == id)).GetValueOrDefault();
        }

        // PUT: api/client/updateWallet/{userId}
        [HttpPut("updateWallet/{userId}")]
        public async Task<IActionResult> UpdateWalletBalance(int userId, [FromBody] WalletUpdateRequest request)
        {
            // Find the client by userId
            var client = await _context.Clients.FirstOrDefaultAsync(c => c.ClientId == userId);

            if (client == null)
            {
                return NotFound(new { success = false, message = "Client not found." });
            }

            // Update the wallet balance
            client.WalletBalance = request.NewBalance;

            // Save changes to the database
            _context.Clients.Update(client);
            await _context.SaveChangesAsync();

            return Ok(new { success = true, newBalance = client.WalletBalance });
        }
    }

    // Request model for updating the wallet balance
    public class WalletUpdateRequest
    {
        public decimal NewBalance { get; set; }
    }



    //[ApiController]
    //[Route("api/[controller]")]
    //public class WalletController : ControllerBase
    //{
    //    private readonly EmcDbContext _context = new EmcDbContext();

    //    //public WalletController(ApplicationDbContext context)
    //    //{
    //    //    _context = context;
    //    //}

    //    // PUT: api/wallet/deduct/{userId}
    //    [HttpPut("deduct/{userId}")]
    //    public async Task<IActionResult> DeductBalance(string userId, [FromBody] DeductionRequest request)
    //    {
    //        // Find the user by their ID
    //        var user = await _context.Users.FirstOrDefaultAsync(u => u.ClientId == userId);

    //        if (user == null)
    //        {
    //            return NotFound(new { success = false, message = "User not found." });
    //        }

    //        // Check if the user has sufficient balance
    //        if (user.WalletBalance < request.Amount)
    //        {
    //            return BadRequest(new { success = false, message = "Insufficient balance." });
    //        }

    //        // Deduct the amount from the user's balance
    //        user.WalletBalance -= request.Amount;

    //        // Update the user's wallet balance in the database
    //        _context.Users.Update(user);
    //        await _context.SaveChangesAsync();

    //        // Return the updated balance to the frontend
    //        return Ok(new { success = true, newBalance = user.WalletBalance });
    //    }
    //}

    //// Request model for the amount to deduct
    //public class DeductionRequest
    //{
    //    public decimal Amount { get; set; }
    //}
}
