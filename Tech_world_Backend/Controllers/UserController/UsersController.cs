using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tech_world_Backend.DTOs.UserProfile;
using Tech_world_Backend.Models;
using Tech_world_Backend.Models.UserProfile;

namespace Tech_world_Backend.Controllers.UserController
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly TechWorldDbContext _techWorldDbContext;
        public UsersController(TechWorldDbContext techWorldDbContext)
        {
            _techWorldDbContext = techWorldDbContext;
        }

        [HttpPost]
        public async Task<ActionResult<RegisterDto>> RegisterUser([FromBody] RegisterDto registerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var user = new User()
            {
                FirstName = registerDto.FirstName,
                MiddelName = registerDto.MiddelName,
                LastName = registerDto.LastName,
                PassWord = registerDto.UserPassword
            };

            await _techWorldDbContext.User.AddAsync(user);
            await _techWorldDbContext.SaveChangesAsync();

            return Ok(new {Message = "User Created Sucessfully"});
        }

        [HttpGet]
        public async Task<ActionResult<UserDto>> GetUser([FromQuery] string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                return BadRequest( new {Message = "Invalid User Name"});
            }
            var user = await _techWorldDbContext.User.FirstOrDefaultAsync(u => u.FirstName == firstName);
            if(user == null)
            {
                return NotFound("User Not Found");
            }
            var userdto =  new UserDto()
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                MiddelName = user.MiddelName,
                LastName = user.LastName
            };

            return Ok(userdto);
        }

    }
}
