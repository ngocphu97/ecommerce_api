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
        public int? Gia { get; set; }
        public int? GiaKM { get; set; }
    }
}
