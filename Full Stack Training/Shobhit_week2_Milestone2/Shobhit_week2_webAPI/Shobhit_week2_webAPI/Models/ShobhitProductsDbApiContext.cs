using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Shobhit_week2_webAPI.Models;

public partial class ShobhitProductsDbApiContext : DbContext
{
    public ShobhitProductsDbApiContext()
    {
    }

    public ShobhitProductsDbApiContext(DbContextOptions<ShobhitProductsDbApiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=5F8CC5A69AAE530; database=Shobhit_ProductsDB_API; integrated security=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CId).HasName("PK__Customer__D830D477FB9A785B");

            entity.Property(e => e.CId)
                .ValueGeneratedNever()
                .HasColumnName("cId");
            entity.Property(e => e.CAddress)
                .IsUnicode(false)
                .HasColumnName("cAddress");
            entity.Property(e => e.CName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("cName");
            entity.Property(e => e.CWalletBalance).HasColumnName("cWalletBalance");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OId).HasName("PK__Orders__C2FECB3B88CBF688");

            entity.Property(e => e.OId)
                .ValueGeneratedNever()
                .HasColumnName("oId");
            entity.Property(e => e.CId).HasColumnName("cId");
            entity.Property(e => e.OStatus)
                .HasMaxLength(50)
                .HasColumnName("oStatus");
            entity.Property(e => e.PId).HasColumnName("pId");

            entity.HasOne(d => d.CIdNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CId)
                .HasConstraintName("fk_cId");

            entity.HasOne(d => d.PIdNavigation).WithMany(p => p.Orders)
                .HasForeignKey(d => d.PId)
                .HasConstraintName("fk_pId");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.PId).HasName("PK__Products__DD36D5621645019C");

            entity.Property(e => e.PId)
                .ValueGeneratedNever()
                .HasColumnName("pId");
            entity.Property(e => e.PAvailableQty).HasColumnName("pAvailableQty");
            entity.Property(e => e.PDescription)
                .IsUnicode(false)
                .HasColumnName("pDescription");
            entity.Property(e => e.PIsInStock).HasColumnName("pIsInStock");
            entity.Property(e => e.PName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("pName");
            entity.Property(e => e.PPrice).HasColumnName("pPrice");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
