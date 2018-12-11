using System;
namespace ThuongMaiDienTuAPI.Dtos.Queries
{
    public class DangKyDichVuDto
    {
        public int IdSeller { get; set; }
        public int IdGoiDichVu { get; set; }
        public DateTime ThoiGianDangKy { get; set; }
    }
}
