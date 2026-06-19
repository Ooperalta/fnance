

using Fnance.Api.DTOs.Users;
using Fnance.Domain.Entities;
using Fnance.Domain.Repositories;

using Microsoft.AspNetCore.Mvc;

namespace Fnance.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest request)
        {

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);
            var user = new User(request.Name, request.Email, passwordHash);

            await _userRepository.AddAsync(user);

            return Ok(new { 
            user.Id,
            user.Name,
            user.Email,
            });


        }
    }
}
