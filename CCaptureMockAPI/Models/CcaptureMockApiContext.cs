using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CCaptureMockAPI.Models;

public partial class CcaptureMockApiContext : DbContext
{
    public CcaptureMockApiContext()
    {
    }

    public CcaptureMockApiContext(DbContextOptions<CcaptureMockApiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DocumentVerificationRequest> DocumentVerificationRequests { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=andrewpc;Database=CCaptureMockAPI;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DocumentVerificationRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Document__3214EC070A08C5AE");

            entity.ToTable("DocumentVerificationRequest");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.BatchClassName).HasMaxLength(255);
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FilePath).HasMaxLength(500);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
