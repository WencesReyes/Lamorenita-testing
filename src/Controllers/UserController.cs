using Lamorenita.Models;
using Lamorenita.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lamorenita.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) 
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(UserCreateModel requestModel)
        {
            return StatusCode(201, await _userService.CreateUserAsync(requestModel));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return StatusCode(200, await _userService.getAllUsersAsync());
        }
    }
}
