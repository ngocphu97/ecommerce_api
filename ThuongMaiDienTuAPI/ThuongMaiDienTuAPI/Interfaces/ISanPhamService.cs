using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuongMaiDienTuAPI.Dtos.Queries;
using ThuongMaiDienTuAPI.Entities;
namespace ThuongMaiDienTuAPI.Interfaces
{
    public interface ISanPhamService
    {
        Task<object> Get(SanPhamQuery query);
        Task<object> Get(int idSeller, SanPhamQuery query);
        Task<bool> Add(int idSeller,SanPham sanPham);
        Task<bool> Delete(int idSeller,int idSanPham);
        Task<bool> Block(int idSeller,int idSanPham);
    }
}
