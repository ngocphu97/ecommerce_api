using System.ComponentModel.DataAnnotations;

namespace ThuongMaiDienTuAPI.Entities
{
    public class ChiTietHD
    {
        [Key]
        public int IdHoaDon { get; set; }
        [Key]
        public int IdPhanLoaiSP { get; set; }
        public int? SoLuong { get; set; }
        public double? Gia { get; set; }
        public double? GiaKM { get; set; }
    }
}
