using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Entities
{
    public class ChiTietHD
    {
        public int IdHoaDon { get; set; }
        public int IdSanPham { get; set; }
        public int? SoLuong { get; set; }
        public int? Gia { get; set; }
        public int? GiaKM { get; set; }
    }
}
