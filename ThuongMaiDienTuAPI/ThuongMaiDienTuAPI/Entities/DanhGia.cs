using System;
using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Entities
{
    public class DanhGia
    {
        [Key]
        public int Id { get; set; }
        public DateTime Ngay { get; set; }
        [MaxLength(500)]
        public string NoiDung { get; set; }
        public double Danhgia { get; set; }
        [Required]
        public int IdUser { get; set; }
        [Required]
        public int IdSeller { get; set; }
    }
}
