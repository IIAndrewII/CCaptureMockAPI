using CCaptureMockAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CCaptureMockAPI.Swagger
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<DocumentVerificationRequest> DocumentVerificationRequests { get; set; }
        public DbSet<DocumentVerificationResponse> DocumentVerificationResponses { get; set; }  // ADD THIS LINE

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DocumentVerificationResponse>().HasKey(d => d.RequestGuid);
        }
    }

}
