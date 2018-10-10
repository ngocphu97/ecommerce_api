using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuongMaiDienTuAPI.Entities;
using ThuongMaiDienTuAPI.Dtos;
namespace ThuongMaiDienTuAPI.Interfaces
{
    public interface IUserService
    {
        Task<User> Get(int id);
        Task<User> Get(string username);
        Task<User> Login(LoginDto login);
    }
}
