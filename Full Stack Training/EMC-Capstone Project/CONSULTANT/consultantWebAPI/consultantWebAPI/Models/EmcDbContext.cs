﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace consultantWebAPI.Models;

public partial class EmcDbContext : DbContext
{
    public EmcDbContext()
    {
    }

    public EmcDbContext(DbContextOptions<EmcDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminAction> AdminActions { get; set; }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<ConsultancyService> ConsultancyServices { get; set; }

    public virtual DbSet<Consultant> Consultants { get; set; }

    public virtual DbSet<Feedback> Feedbacks { get; set; }

    public virtual DbSet<PerformanceTracker> PerformanceTrackers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=5F8CC5A69AAE530;database=emcDB;integrated security=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdminAction>(entity =>
        {
            entity.HasKey(e => e.ActionId).HasName("PK__Admin_Ac__74EFC217A8762D87");

            entity.ToTable("Admin_Actions");

            entity.Property(e => e.ActionId).HasColumnName("action_id");
            entity.Property(e => e.ActionType)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("action_type");
            entity.Property(e => e.AdminId).HasColumnName("admin_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Timestamp)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("timestamp");

            entity.HasOne(d => d.Admin).WithMany(p => p.AdminActions)
                .HasForeignKey(d => d.AdminId)
                .HasConstraintName("FK__Admin_Act__admin__6383C8BA");
        });

        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.AppointmentId).HasName("PK__Appointm__A50828FC8A757F25");

            entity.Property(e => e.AppointmentId).HasColumnName("appointment_id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.ConsultantId).HasColumnName("consultant_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.ScheduledTime)
                .HasColumnType("datetime")
                .HasColumnName("scheduled_time");
            entity.Property(e => e.Status)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("status");

            entity.HasOne(d => d.Client).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK__Appointme__clien__4D94879B");

            entity.HasOne(d => d.Consultant).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.ConsultantId)
                .HasConstraintName("FK__Appointme__consu__4CA06362");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.ClientId).HasName("PK__Clients__BF21A424A47E4F71");

            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.WalletBalance)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("wallet_balance");

            entity.HasOne(d => d.User).WithMany(p => p.Clients)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Clients__user_id__48CFD27E");
        });

        modelBuilder.Entity<ConsultancyService>(entity =>
        {
            entity.HasKey(e => e.ServiceId).HasName("PK__Consulta__3E0DB8AF1B3EB256");

            entity.ToTable("Consultancy_Services");

            entity.Property(e => e.ServiceId).HasColumnName("service_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("price");
            entity.Property(e => e.ServiceName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("service_name");
        });

        modelBuilder.Entity<Consultant>(entity =>
        {
            entity.HasKey(e => e.ConsultantId).HasName("PK__Consulta__680695C45C669B2C");

            entity.Property(e => e.ConsultantId).HasColumnName("consultant_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.ProfileInfo)
                .HasColumnType("text")
                .HasColumnName("profile_info");
            entity.Property(e => e.Rating)
                .HasDefaultValueSql("((0))")
                .HasColumnName("rating");
            entity.Property(e => e.TotalProjects)
                .HasDefaultValueSql("((0))")
                .HasColumnName("total_projects");
            entity.Property(e => e.UserId).HasColumnName("User_id");

            entity.HasOne(d => d.User).WithMany(p => p.Consultants)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Consultan__User___4316F928");
        });

        modelBuilder.Entity<Feedback>(entity =>
        {
            entity.HasKey(e => e.FeedbackId).HasName("PK__Feedback__7A6B2B8CF6A6DEC7");

            entity.ToTable("Feedback");

            entity.Property(e => e.FeedbackId).HasColumnName("feedback_id");
            entity.Property(e => e.AppointmentId).HasColumnName("appointment_id");
            entity.Property(e => e.Comments)
                .HasColumnType("text")
                .HasColumnName("comments");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Rating).HasColumnName("rating");

            entity.HasOne(d => d.Appointment).WithMany(p => p.Feedbacks)
                .HasForeignKey(d => d.AppointmentId)
                .HasConstraintName("FK__Feedback__appoin__534D60F1");
        });

        modelBuilder.Entity<PerformanceTracker>(entity =>
        {
            entity.HasKey(e => e.TrackerId).HasName("PK__Performa__AB2F8881C8C7B890");

            entity.ToTable("Performance_Tracker");

            entity.Property(e => e.TrackerId).HasColumnName("tracker_id");
            entity.Property(e => e.AverageRating)
                .HasDefaultValueSql("((0))")
                .HasColumnName("average_rating");
            entity.Property(e => e.CompletedProjects)
                .HasDefaultValueSql("((0))")
                .HasColumnName("completed_projects");
            entity.Property(e => e.ConsultantId).HasColumnName("consultant_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");

            entity.HasOne(d => d.Consultant).WithMany(p => p.PerformanceTrackers)
                .HasForeignKey(d => d.ConsultantId)
                .HasConstraintName("FK__Performan__consu__59063A47");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__users__CB9A1CFFA279437B");

            entity.ToTable("users", tb => tb.HasTrigger("trg_UpdateTimestamp"));

            entity.HasIndex(e => e.UserName, "UQ__users__66DCF95CB1CB6FC6").IsUnique();

            entity.HasIndex(e => e.UserEmailId, "UQ__users__91B96ED514A3C10C").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.PhoneNum).HasColumnName("phoneNum");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserEmailId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("userEmailId");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("userName");
            entity.Property(e => e.UserPassword)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("userPassword");
            entity.Property(e => e.UserRole)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("userRole");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
