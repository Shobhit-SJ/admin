using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using consultantWebAPIAzure.Models;
using NuGet.Protocol.Plugins;

namespace consultantWebAPIAzure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly EmcDbContext _context = new EmcDbContext();

        //public UsersController(EmcDbContext context)
        //{
        //    _context = context;
        //}

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
          if (_context.Users == null)
          {
              return NotFound();
          }
            return await _context.Users.ToListAsync();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
          if (_context.Users == null)
          {
              return NotFound();
          }
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.UserId)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
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

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
          if (_context.Users == null)
          {
              return Problem("Entity set 'EmcDbContext.Users'  is null.");
          }
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.UserId }, user);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            if (_context.Users == null)
            {
                return NotFound();
            }
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/Users/Login
        [HttpPost("Login")]
        public async Task<ActionResult<bool>> Login([FromBody] LoginRequest loginRequest)
        {
            if (loginRequest == null || string.IsNullOrWhiteSpace(loginRequest.userName) || string.IsNullOrWhiteSpace(loginRequest.userPassword))
            {
                return BadRequest("Invalid login request.");
            }

            if (_context == null || _context.Users == null)
            {
                return NotFound("User not found.");
            }

            // Find the user by UserName
            //var user = await _context.Users.FindAsync(loginRequest.UserName);
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == loginRequest.userName);

            if (user == null)
            {
                return NotFound("User not found.");
            }

            // Check if the password matches
            bool isPasswordValid = loginRequest.userPassword == user.UserPassword;



            if (!isPasswordValid)
            {
                return Unauthorized("Invalid credentials.");
            }

            if (loginRequest.userRole != user.UserRole)
            {
                return Unauthorized("User role mismatch.");
            }

            //return Ok(true);
            int? clientId = null;
            if (user.UserRole == "Client")
            {
                var client = await _context.Clients.FirstOrDefaultAsync(c => c.UserId == user.UserId);
                if (client != null)
                {
                    clientId = client.ClientId;
                    Console.WriteLine(clientId);
                }
            }
            return Ok(new LoginResponse
            {
                IsSuccess = true,
                ClientId = clientId,
                

                // This will be null for consultants
            }) ;

            // return Ok(true); // Login successful
        }
        public class LoginResponse
        {
            public bool IsSuccess { get; set; }
            public int? ClientId { get; set; } // Nullable if not a client
        }

        private bool UserExists(int id)
        {
            return (_context.Users?.Any(e => e.UserId == id)).GetValueOrDefault();
        }
    }
}
