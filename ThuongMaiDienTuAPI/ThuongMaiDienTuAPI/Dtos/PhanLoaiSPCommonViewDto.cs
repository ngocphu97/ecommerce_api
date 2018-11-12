using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThuongMaiDienTuAPI.Dtos
{
    public class PhanLoaiSPCommonViewDto
    {
        public int IdPhanLoaiSP { get; set; }
        public int IdSanPham { get; set; }
        public int SoLuong { get; set; }
        public int? GiaKM { get; set; }
        public int GiaBan { get; set; }
        public string Mau { get; set; }
    }
}
