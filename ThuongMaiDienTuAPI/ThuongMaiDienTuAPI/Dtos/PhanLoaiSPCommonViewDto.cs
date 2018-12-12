namespace ThuongMaiDienTuAPI.Dtos
{
    public class PhanLoaiSPCommonViewDto
    {
        public int IdPhanLoaiSP { get; set; }
        public int IdSanPham { get; set; }
        public int SoLuong { get; set; }
        public string Mau { get; set; }
        public int? GiaKM { get; set; }
        public int? IdKhuyenMai { get; set; }
        public int GiaBan { get; set; }
        
    }
}
