using System;
using System.ComponentModel.DataAnnotations;

namespace ThuongMaiDienTuAPI.Entities
{
    public class DangKyDichVu
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdSeller { get; set; }
        [Required]
        public int IdGoiDichVu { get; set; }
        public DateTime ThoiGianDangKy { get; set; }
    }
}
