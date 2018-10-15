using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Entities
{
    public class DanhGia
    {
        [Key]
        public int IdDanhGia { get; set; }
        public DateTime Ngay { get; set; }
        [MaxLength(150)]
        public string NoiDung { get; set; }
        public double Danhgia { get; set; }
        public int IdSanPham { get; set; }
        public int? IdUser { get; set; }
    }
}
