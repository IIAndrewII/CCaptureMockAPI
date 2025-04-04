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

    public virtual DbSet<AppCredential> AppCredentials { get; set; }

    public virtual DbSet<DocumentVerificationRequest> DocumentVerificationRequests { get; set; }

    public virtual DbSet<DocumentVerificationResponse> DocumentVerificationResponses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=andrewpc;Database=CCaptureMockAPI;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AppCredential>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AppCrede__3214EC073E937572");

            entity.Property(e => e.AppLogin).HasMaxLength(100);
            entity.Property(e => e.ApplicationName).HasMaxLength(100);
            entity.Property(e => e.PasswordHash).HasMaxLength(256);
        });

        modelBuilder.Entity<DocumentVerificationRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Document__3214EC07194850C3");

            entity.Property(e => e.BatchClassName).HasMaxLength(255);
        });

        modelBuilder.Entity<DocumentVerificationResponse>(entity =>
        {
            entity.HasKey(e => e.RequestGuid).HasName("PK__Document__27CC2CAB078D4666");

            entity.Property(e => e.RequestGuid)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ResponseJson).HasColumnType("text");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
