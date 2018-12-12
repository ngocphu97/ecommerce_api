using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Entities
{
    public class PhanLoaiSP
    {
        [Key]
        public int IdPhanLoaiSP { get; set; }
        [Required]
        public int IdSanPham { get; set; }
        public int SoLuong { get; set; }
        public double? GiaKM { get; set; }
        public double GiaBan { get; set; }
        public double GiaGoc { get; set; }
        [MaxLength(20)]
        public string Mau { get; set; }

        public int? IdKhuyenMai { get; set; }
    }
}
