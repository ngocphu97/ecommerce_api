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
    public class ThongKeHoaDonService : IThongKeHoaDonService
    {
        private DataContext db;
        public ThongKeHoaDonService(DataContext db)
        {
            this.db = db;
        }

        public async Task<object> Get(ThongKeHoaDonQuery query)
        {
            var thongKeHoaDon = Paging<ThongKeHoaDon>.Get(Filtering(db.ThongKeHoaDon, query), query);
            return new
            {
                Total = thongKeHoaDon.Count(),
                Content = await Paging<ThongKeHoaDon>.Get(thongKeHoaDon, query).ToListAsync()
            };
        }
        private IQueryable<ThongKeHoaDon> Filtering(IQueryable<ThongKeHoaDon> thongKeHoaDon,ThongKeHoaDonQuery query)
        {
            return thongKeHoaDon;
        }
    }
}
