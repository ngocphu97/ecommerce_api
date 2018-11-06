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
    public class HoaDonService : IHoaDonService
    {
        private DataContext db;
        public HoaDonService(DataContext db)
        {
            this.db = db;
        }

        public async Task<object> GetByCustomer(int idUser,HoaDonQuery query)
        {
            var hoaDon = Sorting<HoaDon>.Get(Filtering(db.HoaDon.Where(x=>x.IdUser==idUser), query), query);
            return new {
                Total = hoaDon.Count(),
                Content= await Paging<HoaDon>.Get(hoaDon,query).Include(x=>x.ChiTietHD).ToListAsync()
            };
        }

        public async Task<object> GetBySeller(int idSeller, HoaDonQuery query)
        {
            var hoaDon = Sorting<HoaDon>.Get(Filtering(db.HoaDon.Where(x=>x.IdSeller==idSeller), query), query);
            return new
            {
                Total = hoaDon.Count(),
                Content = await Paging<HoaDon>.Get(hoaDon, query).Include(x => x.ChiTietHD).ToListAsync()
            };
        }

        private IQueryable<HoaDon> Filtering(IQueryable<HoaDon> hoaDon, HoaDonQuery query)
        {
            if (query.IdUser != null)
            {
                hoaDon = hoaDon.Where(x => x.IdHoaDon == query.IdUser);
            }
            if (query.IdSeller != null)
            {
                hoaDon = hoaDon.Where(x => x.IdSeller == query.IdSeller);
            }
            if (query.TenKH != null)
            {
                hoaDon = from x in hoaDon
                         where x.TenKH.Contains(query.TenKH)
                         select x;
            }
            if (query.Mail != null)
            {
                hoaDon = from x in hoaDon
                         where x.Mail.Contains(query.Mail)
                         select x;
            }
            if (query.SDT != null)
            {
                hoaDon = from x in hoaDon
                         where x.SDT.Contains(query.SDT)
                         select x;
            }
            if (query.PhuongThucTT != null)
            {
                hoaDon = from x in hoaDon
                         where x.PhuongThucTT.Contains(query.PhuongThucTT)
                         select x;
            }
            if (query.TinhTrangTT != null)
            {
                hoaDon = from x in hoaDon
                         where x.TinhTrangTT.Contains(query.TinhTrangTT)
                         select x;
            }
            if (query.TrangThai != null)
            {
                hoaDon = hoaDon.Where(x => x.TrangThai == query.TrangThai);
            }

            return hoaDon;
        }
    }
}
