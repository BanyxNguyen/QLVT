using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace QLVT.Models
{
    public partial class QLVTContext : DbContext
    {
       
        public QLVTContext()
        {
        }
        public QLVTContext(DbContextOptions<QLVTContext> options)
            : base(options)
        {
        }
        public QLVTContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        public static QLVTContext Create(string ConnectionString)
        {
            var optioBuild = new DbContextOptionsBuilder();
            optioBuild.UseSqlServer(ConnectionString);
            return new QLVTContext(optioBuild.Options);
        }
        public virtual DbSet<Chinhanh> Chinhanh { get; set; }
        public virtual DbSet<Ctddh> Ctddh { get; set; }
        public virtual DbSet<Cthd> Cthd { get; set; }
        public virtual DbSet<Ctpn> Ctpn { get; set; }
        public virtual DbSet<Dondathang> Dondathang { get; set; }
        public virtual DbSet<GetSubcriber> GetSubcriber { get; set; }
        public virtual DbSet<Hanghoa> Hanghoa { get; set; }
        public virtual DbSet<Hoadon> Hoadon { get; set; }
        public virtual DbSet<Khachhang> Khachhang { get; set; }
        public virtual DbSet<Kho> Kho { get; set; }
        public virtual DbSet<Loaihh> Loaihh { get; set; }
        public virtual DbSet<Nhacungcap> Nhacungcap { get; set; }
        public virtual DbSet<Nhanvien> Nhanvien { get; set; }
        public virtual DbSet<Phieunhap> Phieunhap { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(Program._connStrDev);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chinhanh>(entity =>
            {
                entity.HasKey(e => e.Macn);

                entity.ToTable("CHINHANH");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_1781581385")
                    .IsUnique();

                entity.Property(e => e.Macn)
                    .HasColumnName("MACN")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Diachi)
                    .HasColumnName("DIACHI")
                    .HasMaxLength(512);

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Ten)
                    .HasColumnName("TEN")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Ctddh>(entity =>
            {
                entity.HasKey(e => new { e.Idhh, e.Idddh });

                entity.ToTable("CTDDH");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_725577623")
                    .IsUnique();

                entity.Property(e => e.Idhh).HasColumnName("IDHH");

                entity.Property(e => e.Idddh).HasColumnName("IDDDH");

                entity.Property(e => e.Dongia).HasColumnName("DONGIA");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.HasOne(d => d.IdddhNavigation)
                    .WithMany(p => p.Ctddh)
                    .HasForeignKey(d => d.Idddh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTDDH_DONDATHANG");

                entity.HasOne(d => d.IdhhNavigation)
                    .WithMany(p => p.Ctddh)
                    .HasForeignKey(d => d.Idhh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTDDH_HANGHOA");
            });

            modelBuilder.Entity<Cthd>(entity =>
            {
                entity.HasKey(e => new { e.Idhh, e.Idhd });

                entity.ToTable("CTHD");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_757577737")
                    .IsUnique();

                entity.Property(e => e.Idhh).HasColumnName("IDHH");

                entity.Property(e => e.Idhd).HasColumnName("IDHD");

                entity.Property(e => e.Dongia).HasColumnName("DONGIA");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.HasOne(d => d.IdhdNavigation)
                    .WithMany(p => p.Cthd)
                    .HasForeignKey(d => d.Idhd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTHD_HOADON");

                entity.HasOne(d => d.IdhhNavigation)
                    .WithMany(p => p.Cthd)
                    .HasForeignKey(d => d.Idhh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTHD_HANGHOA");
            });

            modelBuilder.Entity<Ctpn>(entity =>
            {
                entity.HasKey(e => new { e.Idhh, e.Idpn });

                entity.ToTable("CTPN");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_741577680")
                    .IsUnique();

                entity.Property(e => e.Idhh).HasColumnName("IDHH");

                entity.Property(e => e.Idpn).HasColumnName("IDPN");

                entity.Property(e => e.Dongia).HasColumnName("DONGIA");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.HasOne(d => d.IdhhNavigation)
                    .WithMany(p => p.Ctpn)
                    .HasForeignKey(d => d.Idhh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTPN_HANGHOA");

                entity.HasOne(d => d.IdpnNavigation)
                    .WithMany(p => p.Ctpn)
                    .HasForeignKey(d => d.Idpn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTPN_PHIEUNHAP");
            });

            modelBuilder.Entity<Dondathang>(entity =>
            {
                entity.ToTable("DONDATHANG");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Idk).HasColumnName("IDK");

                entity.Property(e => e.Idncc).HasColumnName("IDNCC");

                entity.Property(e => e.Manv)
                    .HasColumnName("MANV")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ngaylap).HasColumnName("NGAYLAP");

                entity.HasOne(d => d.IdkNavigation)
                    .WithMany(p => p.Dondathang)
                    .HasForeignKey(d => d.Idk)
                    .HasConstraintName("FK_DONDATHANG_KHO");

                entity.HasOne(d => d.IdnccNavigation)
                    .WithMany(p => p.Dondathang)
                    .HasForeignKey(d => d.Idncc)
                    .HasConstraintName("FK_DONDATHANG_NHACUNGCAP");

                entity.HasOne(d => d.ManvNavigation)
                    .WithMany(p => p.Dondathang)
                    .HasForeignKey(d => d.Manv)
                    .HasConstraintName("FK_DONDATHANG_NHANVIEN");
            });

            modelBuilder.Entity<GetSubcriber>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Get_Subcriber");

                entity.Property(e => e.Tencn)
                    .HasColumnName("TENCN")
                    .HasMaxLength(255);

                entity.Property(e => e.Tenserver)
                    .HasColumnName("TENSERVER")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Hanghoa>(entity =>
            {
                entity.ToTable("HANGHOA");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Idlhh).HasColumnName("IDLHH");

                entity.Property(e => e.Mota)
                    .HasColumnName("MOTA")
                    .HasMaxLength(512);

                entity.Property(e => e.Ten)
                    .HasColumnName("TEN")
                    .HasMaxLength(256);

                entity.HasOne(d => d.IdlhhNavigation)
                    .WithMany(p => p.Hanghoa)
                    .HasForeignKey(d => d.Idlhh)
                    .HasConstraintName("FK_HANGHOA_LOAIHH");
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.ToTable("HOADON");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Idk).HasColumnName("IDK");

                entity.Property(e => e.Idkh).HasColumnName("IDKH");

                entity.Property(e => e.Manv)
                    .HasColumnName("MANV")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ngaylap).HasColumnName("NGAYLAP");

                entity.HasOne(d => d.IdkNavigation)
                    .WithMany(p => p.Hoadon)
                    .HasForeignKey(d => d.Idk)
                    .HasConstraintName("FK_HOADON_KHO");

                entity.HasOne(d => d.IdkhNavigation)
                    .WithMany(p => p.Hoadon)
                    .HasForeignKey(d => d.Idkh)
                    .HasConstraintName("FK_HOADON_KHACHHANG");

                entity.HasOne(d => d.ManvNavigation)
                    .WithMany(p => p.Hoadon)
                    .HasForeignKey(d => d.Manv)
                    .HasConstraintName("FK_HOADON_NHANVIEN");
            });

            modelBuilder.Entity<Khachhang>(entity =>
            {
                entity.ToTable("KHACHHANG");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Diachi)
                    .HasColumnName("DIACHI")
                    .HasMaxLength(512);

                entity.Property(e => e.Macn)
                    .HasColumnName("MACN")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Ten)
                    .HasColumnName("TEN")
                    .HasMaxLength(256);

                entity.HasOne(d => d.MacnNavigation)
                    .WithMany(p => p.Khachhang)
                    .HasForeignKey(d => d.Macn)
                    .HasConstraintName("FK_KHACHHANG_CHINHANH");
            });

            modelBuilder.Entity<Kho>(entity =>
            {
                entity.ToTable("KHO");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Diachi)
                    .HasColumnName("DIACHI")
                    .HasMaxLength(512);

                entity.Property(e => e.Macn)
                    .HasColumnName("MACN")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Ten)
                    .HasColumnName("TEN")
                    .HasMaxLength(256);

                entity.HasOne(d => d.MacnNavigation)
                    .WithMany(p => p.Kho)
                    .HasForeignKey(d => d.Macn)
                    .HasConstraintName("FK_KHO_CHINHANH");
            });

            modelBuilder.Entity<Loaihh>(entity =>
            {
                entity.ToTable("LOAIHH");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Ten)
                    .HasColumnName("TEN")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Nhacungcap>(entity =>
            {
                entity.ToTable("NHACUNGCAP");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Diachi)
                    .HasColumnName("DIACHI")
                    .HasMaxLength(512);

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Ten)
                    .HasColumnName("TEN")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.Manv);

                entity.ToTable("NHANVIEN");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("MSmerge_index_2117582582")
                    .IsUnique();

                entity.Property(e => e.Manv)
                    .HasColumnName("MANV")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cmnd)
                    .HasColumnName("CMND")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Diachi)
                    .HasColumnName("DIACHI")
                    .HasMaxLength(512);

                entity.Property(e => e.Ho)
                    .HasColumnName("HO")
                    .HasMaxLength(512);

                entity.Property(e => e.Luong).HasColumnName("LUONG");

                entity.Property(e => e.Macn)
                    .HasColumnName("MACN")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ngaysinh).HasColumnName("NGAYSINH");

                entity.Property(e => e.Phai).HasColumnName("PHAI");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Ten)
                    .HasColumnName("TEN")
                    .HasMaxLength(128);

                entity.Property(e => e.Ttxoa)
                    .HasColumnName("TTXOA")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.MacnNavigation)
                    .WithMany(p => p.Nhanvien)
                    .HasForeignKey(d => d.Macn)
                    .HasConstraintName("FK_NHANVIEN_CHINHANH");
            });

            modelBuilder.Entity<Phieunhap>(entity =>
            {
                entity.ToTable("PHIEUNHAP");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.Idddh).HasColumnName("IDDDH");

                entity.Property(e => e.Idk).HasColumnName("IDK");

                entity.Property(e => e.Manv)
                    .HasColumnName("MANV")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ngaylap).HasColumnName("NGAYLAP");

                entity.HasOne(d => d.IdddhNavigation)
                    .WithMany(p => p.Phieunhap)
                    .HasForeignKey(d => d.Idddh)
                    .HasConstraintName("FK_PHIEUNHAP_DONDATHANG");

                entity.HasOne(d => d.IdkNavigation)
                    .WithMany(p => p.Phieunhap)
                    .HasForeignKey(d => d.Idk)
                    .HasConstraintName("FK_PHIEUNHAP_KHO");

                entity.HasOne(d => d.ManvNavigation)
                    .WithMany(p => p.Phieunhap)
                    .HasForeignKey(d => d.Manv)
                    .HasConstraintName("FK_PHIEUNHAP_NHANVIEN");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
