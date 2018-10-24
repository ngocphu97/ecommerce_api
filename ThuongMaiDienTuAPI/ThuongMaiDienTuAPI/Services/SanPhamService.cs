﻿using System;
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
    public class SanPhamService : ISanPhamService
    {
        DataContext db;
        public SanPhamService(DataContext db)
        {
            this.db = db;
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
        private IQueryable<SanPham> Filtering(IQueryable<SanPham> sp,SanPhamQuery query)
        {
            if (query.TenSP != null)
            {
                sp = from x in sp
                     where x.TenSP.Contains(query.TenSP)
                     select x;
            }
            if (query.TrangThai != null)
            {
                sp = sp.Where(x => x.TrangThai == query.TrangThai);
            }
            if (query.CoSPHot != null)
            {
                sp = sp.Where(x => x.CoSPHot == query.CoSPHot);
            }
            if (query.CoSPHome != null)
            {
                sp = sp.Where(x => x.CoSPHome == query.CoSPHome);
            }
            return sp;
        }
    }
}