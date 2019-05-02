using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreDemo.Data.Entity
{
    public partial class DeveloperTestContext : DbContext
    {
        public DeveloperTestContext()
        {
        }

        public DeveloperTestContext(DbContextOptions<DeveloperTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblTest> TblTest { get; set; }
        public virtual DbSet<TblTestDetail> TblTestDetail { get; set; }
        public virtual DbSet<TblTestType> TblTestType { get; set; }
        public virtual DbSet<TblUserDetail> TblUserDetail { get; set; }
        public virtual DbSet<TblUserType> TblUserType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=NODE_SERVER;Database=DeveloperTest;user id=bhavik;password=sit@123;Trusted_Connection=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<TblTest>(entity =>
            {
                entity.HasKey(e => e.TestId);

                entity.ToTable("tblTest");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.TblTest)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblTest_tblTestType");
            });

            modelBuilder.Entity<TblTestDetail>(entity =>
            {
                entity.ToTable("tblTestDetail");

                entity.Property(e => e.Distance);

                entity.Property(e => e.Fitnessrating)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.TblTestDetail)
                    .HasForeignKey(d => d.TestId)
                    .HasConstraintName("FK_tblTestDetail_tblTest");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblTestDetail)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblTestDetail_tblUserDetail");
            });

            modelBuilder.Entity<TblTestType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("tblTestType");

                entity.Property(e => e.TestTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserDetail>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("tblUserDetail");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.TblUserDetail)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblUserDetail_tblUserType");
            });

            modelBuilder.Entity<TblUserType>(entity =>
            {
                entity.HasKey(e => e.UserTypeId);

                entity.ToTable("tblUserType");

                entity.Property(e => e.UserTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
