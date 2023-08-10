using System;
using System.Collections.Generic;
using DEMO_APP_LICH_HOC.Model.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace DEMO_APP_LICH_HOC.Model.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<GiangVien> GiangViens { get; set; }

    public virtual DbSet<LichHoc> LichHocs { get; set; }

    public virtual DbSet<LopHoc> LopHocs { get; set; }

    public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    public virtual DbSet<ThanhVienLop> ThanhVienLops { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-B52SRBN\\SQLEXPRESS;Initial Catalog=DEMOAPPLICHHOC;Integrated Security=True; TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GiangVien>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<LichHoc>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

            entity.HasOne(d => d.IdLopHocNavigation).WithMany(p => p.LichHocs).HasConstraintName("FK_LichHoc_LopHoc");
        });

        modelBuilder.Entity<LopHoc>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

            entity.HasOne(d => d.IdGiangVienNavigation).WithMany(p => p.LopHocs).HasConstraintName("FK_LopHoc_GiangVien");
        });

        modelBuilder.Entity<NguoiDung>(entity =>
        {
            entity.HasKey(e => e.Username).HasName("PK__NguoiDun__F3DBC5733DB8BA1B");
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<ThanhVienLop>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

            entity.HasOne(d => d.IdLopHocNavigation).WithMany(p => p.ThanhVienLops)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ThanhVienLop_LopHoc");

            entity.HasOne(d => d.IdSinhVienNavigation).WithMany(p => p.ThanhVienLops)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ThanhVienLop_SinhVien");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
