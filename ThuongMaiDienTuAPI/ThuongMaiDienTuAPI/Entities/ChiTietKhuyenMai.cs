using System.ComponentModel.DataAnnotations;

namespace ThuongMaiDienTuAPI.Entities
{
    public class ChiTietKhuyenMai
    {
        [Key]
        public int IdKhuyenMai { get; set; }
        [Key]
        public int IDPhanLoaiSP { get; set; }
    }
}
