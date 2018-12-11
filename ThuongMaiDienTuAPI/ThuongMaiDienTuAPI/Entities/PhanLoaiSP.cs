using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Entities
{
    public class PhanLoaiSP
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdSanPham { get; set; }
        public int SoLuong { get; set; }
        public int? GiaKM { get; set; }
        public int GiaBan { get; set; }
        public int GiaGoc { get; set; }
        [MaxLength(20)]
        public string Mau { get; set; }

        public int IdKhuyenMai { get; set; }
    }
}
