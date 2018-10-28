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
    public class ThoiGianSPHotService : IThoiGianSPHotService
    {
        DataContext db;
        public ThoiGianSPHotService(DataContext db)
        {
            this.db = db;
        }
        public async Task<object> Get(ThoiGianSPHotQuery query)
        {
            var thoiGianSPHot = Sorting<ThoiGianSPHot>.Get(Filtering(db.ThoiGianSPHot, query), query);

            return new
            {
                Total = thoiGianSPHot.Count(),
                Content = await Paging<ThoiGianSPHot>.Get(thoiGianSPHot, query).ToListAsync()
            };
        }
        private IQueryable<ThoiGianSPHot> Filtering(IQueryable<ThoiGianSPHot> thoiGianSPHot,ThoiGianSPHotQuery query)
        {
            
            return thoiGianSPHot;
        }
    }
}
