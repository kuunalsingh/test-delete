using EntropyAuthApp.Data;
using EntropyAuthApp.Models;
using EntropyAuthApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace EntropyAuthApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AuthContext _context;
        private readonly AuthService _authService;

        public AuthController(AuthContext context, AuthService authService)
        {
            _context = context;
            _authService = authService;
        }

        [HttpPost("register")]
        public IActionResult RegisterUser(string username)
        {
            var authKey = _authService.GenerateAuthKey();

            var user = new User
            {
                Username = username,
                AuthKey = authKey
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok(new { user.Id, user.Username, user.AuthKey });
        }
    }
}
