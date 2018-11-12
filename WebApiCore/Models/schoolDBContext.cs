using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.SqlServer.Infrastructure.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApiCore.Models
{
    public partial class schoolDBContext : DbContext
    {
        public schoolDBContext()
        {
        }
        public schoolDBContext(DbContextOptions<schoolDBContext> options)
            : base(options)
        {
        }
        public virtual DbSet<HocSinh> HocSinh { get; set; }
        public virtual DbSet<HocSinhInfo> HocSinhInfo { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlServer(this.connectionString);
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HocSinh>(entity =>
            {
                entity.ToTable("HOC_SINH");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Class)
                    .HasColumnName("class")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HocSinhInfo>(entity =>
            {
                entity.ToTable("HOC_SINH_INFO");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(200);

                entity.Property(e => e.Birthday)
                    .HasColumnName("birthday")
                    .HasColumnType("date");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });
        }
    }
}
