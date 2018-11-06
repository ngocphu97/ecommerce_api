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
    public class ThongBaoService : IThongBaoService
    {
        DataContext db;
        public ThongBaoService(DataContext db)
        {
            this.db = db;
        }

        public async Task<object> Get(int idUser,ThongBaoQuery query)
        {
            var thongBao = Sorting<ThongBao>.Get(Filtering(db.ThongBao.Where(x=>x.IdUser==idUser), query), query);
            return new
            {
                Total = thongBao.Count(),
                Content = await Paging<ThongBao>.Get(thongBao, query).ToListAsync()
            };
        }
        private IQueryable<ThongBao> Filtering(IQueryable<ThongBao> thongBao,ThongBaoQuery query)
        {
            if (query.TinhTrang != null)
            {
                thongBao = thongBao.Where(x => x.TinhTrang == query.TinhTrang);
            }

            return thongBao;
        }
    }
}
