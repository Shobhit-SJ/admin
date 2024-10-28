using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace projectManagementMVC.Models;

public partial class ProjectManagementContext : DbContext
{
    public ProjectManagementContext()
    {
    }

    public ProjectManagementContext(DbContextOptions<ProjectManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ProjectDetail> ProjectDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:kpmgtraining-shobhitjaiswal.database.windows.net,1433;Initial Catalog=projectManagement;Persist Security Info=False;User ID=shobhitjaiswalkpmg;Password=Shobhit16@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProjectDetail>(entity =>
        {
            entity.HasKey(e => e.ProjectId).HasName("PK__projectD__11F14DA5FFCB3E20");

            entity.ToTable("projectDetails");

            entity.Property(e => e.ProjectId)
                .ValueGeneratedNever()
                .HasColumnName("projectId");
            entity.Property(e => e.ProjectDomain)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("projectDomain");
            entity.Property(e => e.ProjectHead)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("projectHead");
            entity.Property(e => e.ProjectLead)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("projectLead");
            entity.Property(e => e.ProjectName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("projectName");
            entity.Property(e => e.ProjectPrice)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("projectPrice");
            entity.Property(e => e.ProjectStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("projectStatus");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
