using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace firstWebApp.ModelS;

public partial class PersonalDbContext : DbContext
{
    public PersonalDbContext()
    {
    }

    public PersonalDbContext(DbContextOptions<PersonalDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Friend> Friends { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=5F8CC5A69AAE530 ;database=personalDB;integrated security=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Friend>(entity =>
        {
            entity.HasKey(e => e.FriendId).HasName("PK__friends__6A5D67173C741277");

            entity.ToTable("friends");

            entity.Property(e => e.FriendId)
                .ValueGeneratedNever()
                .HasColumnName("friendId");
            entity.Property(e => e.FriendEmail)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("friendEmail");
            entity.Property(e => e.FriendMobile).HasColumnName("friendMobile");
            entity.Property(e => e.FriendName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("friendName");
            entity.Property(e => e.FriendType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("friendType");
            entity.Property(e => e.SeriousFriend).HasColumnName("seriousFriend");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
