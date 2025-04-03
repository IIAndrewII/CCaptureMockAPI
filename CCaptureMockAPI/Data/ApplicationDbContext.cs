using CCaptureMockAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CCaptureMockAPI.Swagger
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<DocumentVerificationRequest> DocumentVerificationRequests { get; set; }
    }

}
