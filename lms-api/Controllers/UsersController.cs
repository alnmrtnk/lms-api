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
            var isValidUser = await _userRepository.ValidateUserCredentialsAsync(loginRequest.Email, loginRequest.Password);
            if (!isValidUser) return Unauthorized("Invalid email or password.");

            var user = await _userRepository.GetUserByEmailAsync(loginRequest.Email);
            return Ok(new { Username  = user?.Username, userId = user?.Id, Role = user?.Role });
        }

        [HttpGet("readers")]
        public async Task<IActionResult> GetReaders()
        {
            var readers = await _userRepository.GetReaders();
            return Ok(readers);
        }
    }
}
