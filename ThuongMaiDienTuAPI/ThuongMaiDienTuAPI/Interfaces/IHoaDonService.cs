using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuongMaiDienTuAPI.Entities;
using ThuongMaiDienTuAPI.Dtos.Queries;
namespace ThuongMaiDienTuAPI.Interfaces
{
    public interface IHoaDonService
    {
        Task<object> GetByCustomer(int idUser,HoaDonQuery query);
        Task<object> GetBySeller(int idSeller,HoaDonQuery query);
        Task<object> Add(int? idUser, HoaDon hoaDon);
    }
}
