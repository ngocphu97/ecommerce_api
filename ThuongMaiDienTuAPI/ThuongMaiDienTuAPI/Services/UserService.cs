using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuongMaiDienTuAPI.Dtos;
using ThuongMaiDienTuAPI.Entities;
using ThuongMaiDienTuAPI.Interfaces;
using ThuongMaiDienTuAPI.Helpers;
using Microsoft.EntityFrameworkCore;

namespace ThuongMaiDienTuAPI.Services
{
    public class UserService : IUserService
    {
        DataContext db; 
        public UserService(DataContext db)
        {
            this.db = db;
        }
        public async Task<User> Get(int id)
        {
            return await db.User.FindAsync(id);
        }

        public async Task<User> Get(string username)
        {
            return await db.User.Where(x => x.TenDN == username).FirstOrDefaultAsync();
        }

        public async Task<User> Login(LoginDto login)
        {
            User user = await Get(login.TenDN);
            if (user == null||user.Matkhau!=Encryptor.MD5Hash(login.Matkhau))
                return null;
            return user;
        }
    }
}
