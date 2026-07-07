using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TripShare.API.Data;
using TripShare.API.DTOs;
using TripShare.API.Models;

namespace TripShare.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
            
        }
        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            var userList = await _context.Users.Select(dtouser => new UserDto
            {
                UserId = dtouser.UserId,
                EmailAddress = dtouser.EmailAddress,
                FullName = dtouser.FullName
            }).ToListAsync();
            return Ok(userList);
        }


        [HttpPost("register")]

        public async Task<IActionResult> RegisterUser([FromBody] UserRegisterDto incomingData)
        {
            var newUser = new User
            {
                FullName = incomingData.FullName,
                EmailAddress = incomingData.EmailAddress,
                Address = incomingData.Address,
                UserIdentification = incomingData.UserIdentification
            };
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();
            return Ok("User Created Successfully");

        }
    }
}
