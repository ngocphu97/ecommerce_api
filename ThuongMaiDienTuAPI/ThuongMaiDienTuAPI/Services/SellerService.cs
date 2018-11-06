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
    public class SellerService : ISellerService
    {
        DataContext db;
        public SellerService(DataContext db)
        {
            this.db = db;
        }
        public async Task<object> Get(SellerQuery query)
        {
            var sellers = Sorting<Seller>.Get(Filtering(db.Seller, query), query);
            return new
            {
                Total = sellers.Count(),
                Content = await Paging<Seller>.Get(sellers, query).Include(x=>x.DiaChi).ToListAsync()
            };
        }

        public async Task<Seller> GetByIdUser(int idUser)
        {
            User user = (await db.User.FindAsync(idUser));
            if (user.LoaiUser != ConstantVariable.UserPermission.SELLER)
                return null;
            return await db.Seller.FindAsync(user.IdSeller);
        }

        private IQueryable<Seller> Filtering(IQueryable<Seller> sellers,SellerQuery query)
        {
            if (query.TenSeller != null)
            {
                sellers = from x in sellers
                          where x.TenSeller.Contains(query.TenSeller)
                          select x;
            }
            if (query.CMND != null)
            {
                sellers = from x in sellers
                          where x.CMND.Contains(query.CMND)
                          select x;
            }
            if (query.Mail != null)
            {
                sellers = from x in sellers
                          where x.Mail.Contains(query.Mail)
                          select x;
            }
            if (query.CheckMail != null)
            {
                sellers = sellers.Where(x => x.CheckMail == query.CheckMail);
            }
            if (query.CheckCMND != null)
            {
                sellers = sellers.Where(x => x.CheckCMND == query.CheckCMND);
            }

            return sellers;
        }
    }
}
