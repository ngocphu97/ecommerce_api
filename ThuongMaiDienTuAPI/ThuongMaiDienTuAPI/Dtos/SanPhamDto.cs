using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThuongMaiDienTuAPI.Dtos
{
    public class SanPhamDto
    {
        public string TenSP { get; set; }
        public string TenKhac { get; set; }

        public CauHinhDto CauHinh { get; set; }

        public List<PhanLoaiSPDto> PhanLoaiSP { get; set; }
        public int IdDanhMuc { get; set; }
        public string Mota { get; set; }
        public string NoiDung { get; set; }
        public string Hinh { get; set; }
        public string HinhCT { get; set; }
        public string ThoiGianBH { get; set; }
        public string TinhTrangHang { get; set; }
    }
}
