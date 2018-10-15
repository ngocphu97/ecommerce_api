using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ThuongMaiDienTuAPI.Entities;
namespace ThuongMaiDienTuAPI.Helpers
{
    /// <summary>
    /// Connect database map entities
    /// </summary>
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> op) : base(op) { }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Seller> Seller { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<ChiTietHD> ChiTietHD { get; set; }
        public virtual DbSet<DanhGia> DanhGia { get; set; }
        public virtual DbSet<DiaChi> DiaChi { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<ThongKeHoaDon> ThongKeHoaDon { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ChiTietHD>().HasKey(x => new { x.IdHoaDon, x.IdSanPham });
            builder.Entity<ChiTietHD>().HasOne<HoaDon>().WithMany(x => x.ChiTietHD).HasForeignKey(x => x.IdHoaDon);

            builder.Entity<ThongKeHoaDon>().HasKey(x => new { x.IdHoaDon, x.IdSeller });

            builder.Entity<DiaChi>().HasOne<KhachHang>().WithOne(x => x.DiaChi);
            builder.Entity<DiaChi>().HasOne<Seller>().WithOne(x => x.DiaChi);
        }
    }
}