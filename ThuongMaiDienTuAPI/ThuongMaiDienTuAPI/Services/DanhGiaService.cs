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
