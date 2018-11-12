using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ThuongMaiDienTuAPI.Dtos.Queries;
using ThuongMaiDienTuAPI.Interfaces;
using ThuongMaiDienTuAPI.Entities;
using ThuongMaiDienTuAPI.Helpers;
using Microsoft.EntityFrameworkCore;
namespace ThuongMaiDienTuAPI.Services
{
    public class DanhGiaService : IDanhGiaService
    {
        private DataContext db;
        public DanhGiaService(DataContext db)
        {
            this.db = db;
        }

        public async Task<bool> Add(int idUser,DanhGia danhGia)
        {
            bool isHad = db.HoaDon.Where(
                x => x.IdUser == idUser &&
                //x.ChiTietHD.Any(y => y.IdSanPham == danhGia.IdSanPham) &&
                x.TinhTrangTT == ConstantVariable.PaymentStatus.COMPLETED &&
                x.TrangThai == true).Any();
            if (!isHad)
                return false;
            danhGia.Ngay = DateTime.Now;
            danhGia.IdUser = idUser;
            await db.DanhGia.AddAsync(danhGia);
            await db.SaveChangesAsync();
            return true;
        }

        public async Task<object> Get(DanhGiaQuery query)
        {
            var danhGia = Sorting<DanhGia>.Get(Filtering(db.DanhGia, query), query);
            return new
            {
                Total = danhGia.Count(),
                Content = await Paging<DanhGia>.Get(danhGia, query).ToListAsync()
            };
        }

        private IQueryable<DanhGia> Filtering(IQueryable<DanhGia> danhGia,DanhGiaQuery query)
        {
            if (query.FromDanhGia != null)
            {
                danhGia = danhGia.Where(x => x.Danhgia >= query.FromDanhGia);
            }
            if (query.ToDanhGia != null)
            {
                danhGia = danhGia.Where(x => x.Danhgia <= query.ToDanhGia);
            }
            if (query.IdSanPham != null)
            {
                danhGia = danhGia.Where(x => x.IdSanPham == query.IdSanPham);
            }
            return danhGia;
        }
    }
}
