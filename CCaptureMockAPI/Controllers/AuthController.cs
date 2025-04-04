using CCaptureMockApi.Services;
using CCaptureMockApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CCaptureMockAPI.Swagger;
using System.Security.Cryptography;
using System.Text;
using System.Linq;

namespace CCaptureMockApi.Controllers
{
    [ApiController]
    [Route("ProcessDocument")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;
        private readonly ApplicationDbContext _context;

        public AuthController(ApplicationDbContext context)
        {
            _context = context;
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

            // Hash the incoming password using SHA-256
            var hashedPassword = ComputeSha256Hash(credentials.AppPassword);

            // Query database for matching credentials
            var validApp = _context.AppCredentials.FirstOrDefault(a =>
                a.ApplicationName == credentials.ApplicationName &&
                a.AppLogin == credentials.AppLogin &&
                a.PasswordHash == hashedPassword);

            if (validApp == null)
            {
                return Unauthorized(new { result = "Invalid credentials." });
            }

            // If valid, generate token
            var token = _authService.GenerateJwtToken(credentials.ApplicationName);
            return Ok(new { result = token });
        }

        // SHA-256 hashing method
        private static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                var bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                var builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString().ToUpper(); // Store & compare in uppercase
            }
        }
    }
}
