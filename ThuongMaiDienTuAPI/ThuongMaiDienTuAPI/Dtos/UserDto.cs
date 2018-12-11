namespace ThuongMaiDienTuAPI.Dtos
{
    public class UserDto
    {
        public int IdUser { get; set; }
        public string TenDN { get; set; }
        public bool TrangThai { get; set; }
        public string LoaiUser { get; set; }
        public int IdKhachHang { get; set; }
        public int? IdSeller { get; set; }
    }
}
