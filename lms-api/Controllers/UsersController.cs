using lms_api.Application.Users.Models;
using lms_api.Application.Users.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace lms_api.Controllers
{
    [Route("users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(User user)
        {
            await _userRepository.AddUserAsync(user);
            return Ok("User registered successfully.");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            var isValidUser = await _userRepository.ValidateUserCredentialsAsync(loginRequest.Username, loginRequest.Password);
            if (!isValidUser) return Unauthorized("Invalid username or password.");

            var user = await _userRepository.GetUserByUsernameAsync(loginRequest.Username);
            return Ok(new { Username  = user?.Username, Role = user?.Role });
        }
    }
}
