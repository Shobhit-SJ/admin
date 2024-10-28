using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AirlineAPI.Models;

public partial class AirlinesApidbContext : DbContext
{
    public AirlinesApidbContext()
    {
    }

    public AirlinesApidbContext(DbContextOptions<AirlinesApidbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BookingInfo> BookingInfos { get; set; }

    public virtual DbSet<FlightScheduleInfo> FlightScheduleInfos { get; set; }

    public virtual DbSet<PassengerInfo> PassengerInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=5F8CC5A69AAE530; database=AirlinesAPIDB; integrated security=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookingInfo>(entity =>
        {
            entity.HasKey(e => e.Pnrno).HasName("PK__BookingI__4677517BC7310CB7");

            entity.ToTable("BookingInfo");

            entity.Property(e => e.Pnrno)
                .ValueGeneratedNever()
                .HasColumnName("PNRNo");
            entity.Property(e => e.FlightDate).HasColumnType("date");
            entity.Property(e => e.FlightStatus)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Flight).WithMany(p => p.BookingInfos)
                .HasForeignKey(d => d.FlightId)
                .HasConstraintName("fk_pId");
        });

        modelBuilder.Entity<FlightScheduleInfo>(entity =>
        {
            entity.HasKey(e => e.FightId).HasName("PK__FlightSc__F171387A84083C3F");

            entity.ToTable("FlightScheduleInfo");

            entity.Property(e => e.FightId)
                .ValueGeneratedNever()
                .HasColumnName("fightId");
            entity.Property(e => e.AircraftType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Airline)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Destination)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SourceCity)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PassengerInfo>(entity =>
        {
            entity.HasKey(e => e.PassengerId).HasName("PK__Passenge__88915FB07D5BC735");

            entity.ToTable("PassengerInfo");

            entity.HasIndex(e => e.Panno, "UQ__Passenge__2C9A485F4FCCA056").IsUnique();

            entity.Property(e => e.PassengerId).ValueGeneratedNever();
            entity.Property(e => e.Address).IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Panno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PANNo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
