using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace productAPI.Models;

public partial class ProductApidbContext : DbContext
{
    public ProductApidbContext()
    {
    }

    public ProductApidbContext(DbContextOptions<ProductApidbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<ProductList> ProductLists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=5F8CC5A69AAE530; database=productAPIDB; integrated security=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CId).HasName("PK__customer__D830D47725310534");

            entity.ToTable("customers");

            entity.Property(e => e.CId)
                .ValueGeneratedNever()
                .HasColumnName("cId");
            entity.Property(e => e.CAddress)
                .IsUnicode(false)
                .HasColumnName("cAddress");
            entity.Property(e => e.CBalance).HasColumnName("cBalance");
            entity.Property(e => e.CName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("cName");
        });

        modelBuilder.Entity<ProductList>(entity =>
        {
            entity.HasKey(e => e.PId).HasName("PK__ProductL__DD36D562355C4894");

            entity.ToTable("ProductList");

            entity.Property(e => e.PId)
                .ValueGeneratedNever()
                .HasColumnName("pId");
            entity.Property(e => e.PCategory)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pCategory");
            entity.Property(e => e.PIsInStock).HasColumnName("pIsInStock");
            entity.Property(e => e.PName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("pName");
            entity.Property(e => e.PPrice).HasColumnName("pPrice");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
