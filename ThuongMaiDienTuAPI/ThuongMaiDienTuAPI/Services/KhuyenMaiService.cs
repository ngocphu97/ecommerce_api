﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ThuongMaiDienTuAPI.Dtos.Queries;
using ThuongMaiDienTuAPI.Entities;
using ThuongMaiDienTuAPI.Helpers;
using ThuongMaiDienTuAPI.Interfaces;
using static ThuongMaiDienTuAPI.Helpers.ConstantVariable;

namespace ThuongMaiDienTuAPI.Services
{
    public class KhuyenMaiService : IKhuyenMaiService
    {
        DataContext db;
        public KhuyenMaiService(DataContext db)
        {
            this.db = db;
        }

        public async Task<bool> Add(int IdUser, KhuyenMai khuyenMai)
        {
            await db.KhuyenMai.AddAsync(khuyenMai);
            await db.SaveChangesAsync();
            return true;
        }


        public async Task<object> Get(KhuyenMaiQuery khuyenMaiQuery)
        {
            var khuyenMai = Sorting<KhuyenMai>.Get(Filtering(db.KhuyenMai, khuyenMaiQuery),khuyenMaiQuery);
            return new
            {
                Total = khuyenMai.Count(),
                Content = await Paging<KhuyenMai>.Get(khuyenMai,khuyenMaiQuery).ToListAsync()
            };
        }

        private IQueryable<KhuyenMai> Filtering(IQueryable<KhuyenMai> khuyenMais,KhuyenMaiQuery query)
        {

            if(query.IdNguoiTao != -1)
            {
                khuyenMais = khuyenMais.Where(x => x.IdNguoiTao == query.IdNguoiTao);
                if(query.NgayKetThuc != null)
                {
                    khuyenMais = khuyenMais.Where(x => x.NgayKetThuc <= query.NgayKetThuc);
                }
            }
            else
            {
                khuyenMais = khuyenMais.Where(x => x.LoaiKhuyenMai == PromotionStatus.COMMON);
            }

            return khuyenMais;
        }

        public async Task<object> GetBySeller(int IdSeller, KhuyenMaiQuery query)
        {
            var khuyenMais = Sorting<KhuyenMai>.Get(db.KhuyenMai.Where(x => x.IdNguoiTao == IdSeller),query);
            return new
            {
                Total = khuyenMais.Count(),
                Content = await GetBySeller(Paging<KhuyenMai>.Get(khuyenMais, query).Include(x => x.ChiTietKM))
            };
        }

        private async Task<object> GetBySeller(IQueryable<KhuyenMai> khuyenMais)
        {
            return await khuyenMais.Select(x => new
            {
                Id = x.Id,
                Ten = x.Ten,
                IdNguoiTao = x.IdNguoiTao,
                PhamTramKM = x.PhamTramKM,
                NgayBatDau = x.NgayBatDau,
                NgayKetThuc = x.NgayKetThuc,
                TinhTrang = x.TinhTrang,
                LoaiKhuyenMai = x.LoaiKhuyenMai,
                ChiTietKM = db.ChiTietKhuyenMai.Select(y => new
                {
                    IdKhuyenMai = y.IdKhuyenMai,
                    IDPhanLoaiSP = y.IDPhanLoaiSP
                })
            }).ToListAsync();
        }
    }
}
