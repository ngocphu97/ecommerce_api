using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Entities
{
    public class KhachHang
    {
        [Key]
        public int IdKhachHang { get; set; }
        public int IdUser { get; set;  }
        [MaxLength(100)]
        public string TenKH { get; set; }
        [MaxLength(13)]
        [Phone]
        public string SDT { get; set; }

        public int IdDiaChi { get; set; }
        public DiaChi DiaChi { get; set; }
        [MaxLength(50)]
        [EmailAddress]
        public string Mail { get; set; }
        public double DanhGia { get; set; }
        public int Diem { get; set; }
    }
}
