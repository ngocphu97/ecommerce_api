using System;
using System.Collections.Generic;
using ThuongMaiDienTuAPI.Entities;

namespace ThuongMaiDienTuAPI.Dtos
{
    public class SanPhamCommonViewDto
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public string TenKhac { get; set; }

        public int IdCauHinh { get; set; }
        public CauHinh CauHinh { get; set; }

        public List<PhanLoaiSPCommonViewDto> PhanLoaiSP { get; set; }
        public int IdDanhMuc { get; set; }
        public int IdSeller { get; set; }
        public string Mota { get; set; }
        public string NoiDung { get; set; }
        public string Hinh { get; set; }
        public string HinhCT { get; set; }
        public string ThoiGianBH { get; set; }
        public int SLXem { get; set; }
        public bool CoSPHome { get; set; }
        public bool CoSPHot { get; set; }
        public DateTime NgayTao { get; set; }
        public bool TrangThai { get; set; }
        public string TinhTrangHang { get; set; }
    }
}
