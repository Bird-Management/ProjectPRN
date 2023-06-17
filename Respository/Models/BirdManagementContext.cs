﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Respository.Models
{
    public partial class BirdManagementContext : DbContext
    {
        public BirdManagementContext()
        {
        }

        public BirdManagementContext(DbContextOptions<BirdManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
<<<<<<< HEAD
                optionsBuilder.UseSqlServer("Data Source=MINHNGUYEN\\SQLEXPRESS;Initial Catalog=BirdManagement;Persist Security Info=True;User ID=sa;Password=sa");
=======
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-QKQ1PQ7\\SQLEXPRESS;Initial Catalog=BirdManagement;User ID=sa;Password=sa");
>>>>>>> 1062abc77efa1e2dd0233f09b1315691e0f0ae58
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.UId)
                    .HasName("PK__Account__DD771E3C5D44D2D1");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Cid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}