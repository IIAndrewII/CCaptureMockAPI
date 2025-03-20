using CCaptureMockApi.Services;
using CCaptureMockApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CCaptureMockApi.Controllers
{
    [ApiController]
    [Route("ProcessDocument")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController()
        {
            _authService = new AuthService();
        }

        [HttpPost("GetToken")]
        public IActionResult GetToken([FromBody] Credentials credentials)
        {
            if (string.IsNullOrEmpty(credentials.ApplicationName))
            {
                return BadRequest("Application name is required.");
            }

            if (string.IsNullOrEmpty(credentials.AppLogin) || string.IsNullOrEmpty(credentials.AppPassword))
            {
                return BadRequest(new { result = "App login and password are required." });
            }

            var token = _authService.GenerateJwtToken(credentials.ApplicationName);
            return Ok(new { result = token });
        }
    }
}
