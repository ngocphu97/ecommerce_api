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
        //----------------------------------------------------------------------------------
        public virtual DbSet<ThongBao> ThongBao { get; set; }
        public virtual DbSet<ThoiGianSPHot> ThoiGianSPHot { get; set; }
        public virtual DbSet<CauHinh> CauHinh { get; set; }
        public virtual DbSet<PhanLoaiSP> PhanLoaiSP { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<DanhMucSP> DanhMucSP { get; set; }
        public virtual DbSet<Page> Page { get; set; }
        public virtual DbSet<Slide> Slide { get; set; }
        public virtual DbSet<XacNhanMail> XacNhanMail { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ChiTietHD>().HasKey(x => new { x.IdHoaDon, x.IdPhanLoaiSP });
            builder.Entity<ChiTietHD>().HasOne<HoaDon>().WithMany(x => x.ChiTietHD).HasForeignKey(x => x.IdHoaDon);


            builder.Entity<DiaChi>().HasOne<KhachHang>().WithOne(x => x.DiaChi).HasForeignKey<KhachHang>(x=>x.IdDiaChi);
            builder.Entity<DiaChi>().HasOne<Seller>().WithOne(x => x.DiaChi).HasForeignKey<Seller>(x=>x.IdDiaChi);

            builder.Entity<CauHinh>().HasOne<SanPham>().WithOne(x => x.CauHinh).HasForeignKey<SanPham>(x=>x.IdCauHinh);
            builder.Entity<PhanLoaiSP>().HasOne<SanPham>().WithMany(x => x.PhanLoaiSP).HasForeignKey(x => x.IdSanPham).OnDelete(DeleteBehavior.Cascade);
        }
    }
}