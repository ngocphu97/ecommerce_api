using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Dtos
{
    public class DanhGiaDto
    {
        [MaxLength(150)]
        [Required]
        public string NoiDung { get; set; }
        public double Danhgia { get; set; }
        public int IdSanPham { get; set; }
    }
}
