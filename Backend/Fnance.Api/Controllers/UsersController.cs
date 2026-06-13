

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
    }
}
