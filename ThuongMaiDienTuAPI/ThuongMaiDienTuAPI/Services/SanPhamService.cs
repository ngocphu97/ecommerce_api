using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuongMaiDienTuAPI.Dtos.Queries;
using ThuongMaiDienTuAPI.Interfaces;
using ThuongMaiDienTuAPI.Entities;
using ThuongMaiDienTuAPI.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace ThuongMaiDienTuAPI.Services
{
    public class SanPhamService : ISanPhamService
    {
        DataContext db;
        public SanPhamService(DataContext db)
        {
            this.db = db;
        }

        #region Events

        public async Task<bool> Add(int idSeller,SanPham sanPham)
        {

            using (IDbContextTransaction transaction = db.Database.BeginTransaction())
            {
                try
                {
                    sanPham.CoSPHome = sanPham.CoSPHot = false;
                    sanPham.NgayTao = DateTime.Now;
                    sanPham.TrangThai = true;
                    sanPham.SLXem = 0;
                    sanPham.IdSeller = idSeller;
                    await db.SanPham.AddAsync(sanPham);
                    await db.SaveChangesAsync();
                    sanPham.TenKhac = sanPham.Ten.ConvertToUnSign3().Replace(' ', '-') + ":" + sanPham.Id.ToString();
                    await db.SaveChangesAsync();
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public async Task<bool> Block(int idSeller,int idSanPham)
        {
            SanPham sanPham = await db.SanPham.FindAsync(idSanPham);
            if (sanPham == null || sanPham.IdSeller != idSeller)
                return false;
            sanPham.TrangThai = false;
            await db.SaveChangesAsync();
            return false;
        }

        public async Task<bool> Delete(int idSeller,int idSanPham)
        {
            SanPham sanPham = await db.SanPham.Where(x => x.Id == idSanPham).Include(x => x.PhanLoaiSP).FirstOrDefaultAsync();
            if (sanPham == null || sanPham.IdSeller != idSeller)
                return false;
            db.SanPham.Remove(sanPham);
            await db.SaveChangesAsync();
            return true;
        }

        public async Task<object> Get(SanPhamQuery query)
        {
            var sanpham = Sorting<SanPham>.Get(Filtering(db.SanPham, query), query);
            return new
            {
                Total = sanpham.Count(),
                Content = await Paging<SanPham>.Get(sanpham, query).Include(x=>x.CauHinh).Include(x=>x.PhanLoaiSP).ToListAsync()
            };
        }

        public async Task<object> Get(int idSeller, SanPhamQuery query)
        {
            var sanpham = Sorting<SanPham>.Get(Filtering(db.SanPham.Where(x=>x.IdSeller==idSeller), query), query);
            return new
            {
                Total = sanpham.Count(),
                Content = await Paging<SanPham>.Get(sanpham, query).Include(x => x.CauHinh).Include(x => x.PhanLoaiSP).ToListAsync()
            };
        }

        private IQueryable<SanPham> Filtering(IQueryable<SanPham> sp,SanPhamQuery query)
        {
            if (query.IdSeller != null)
            {
                sp = sp.Where(x => x.IdSeller == query.IdSeller);
            }
            if (query.TenSP != null)
            {
                sp = from x in sp
                     where x.Ten.Contains(query.TenSP)
                     select x;
            }
            if (query.TrangThai != null)
            {
                sp = sp.Where(x => x.TrangThai == query.TrangThai);
            }
            if (query.IdDanhMuc != null)
            {
                sp = sp.Where(x => x.IdDanhMuc == query.IdDanhMuc);
            }
            if (query.CoSPHot != null)
            {
                sp = sp.Where(x => x.CoSPHot == query.CoSPHot);
            }
            if (query.CoSPHome != null)
            {
                sp = sp.Where(x => x.CoSPHome == query.CoSPHome);
            }
            if (query.FromGiaKM != null)
            {
                sp = sp.Where(x => x.PhanLoaiSP.Any(y => y.GiaKM >= query.FromGiaKM));
            }
            if (query.ToGiaKM != null)
            {
                sp = sp.Where(x => x.PhanLoaiSP.Any(y => y.GiaKM <= query.ToGiaKM));
            }
            if (query.FromSoLuong != null)
            {
                sp = sp.Where(x => x.PhanLoaiSP.Any(y => y.SoLuong >= query.FromSoLuong));
            }
            if (query.ToSoLuong != null)
            {
                sp = sp.Where(x => x.PhanLoaiSP.Any(y => y.SoLuong <= query.ToSoLuong));
            }
            return sp;
        }
        #endregion
    }
}
