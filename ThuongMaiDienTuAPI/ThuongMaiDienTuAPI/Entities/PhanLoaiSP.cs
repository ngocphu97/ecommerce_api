using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Entities
{
    public class PhanLoaiSP
    {
        [Key]
        public int IdPhanLoaiSP { get; set; }
        public int IdSanPham { get; set; }
        public int SoLuong { get; set; }
        public int? GiaKM { get; set; }
        public int GiaBan { get; set; }
        public int GiaGoc { get; set; }
        public string Mau { get; set; }
    }
}
