using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuongMaiDienTuAPI.Dtos.Queries;
namespace ThuongMaiDienTuAPI.Interfaces
{
    public interface ISanPhamService
    {
        Task<object> Get(SanPhamQuery query);
    }
}
