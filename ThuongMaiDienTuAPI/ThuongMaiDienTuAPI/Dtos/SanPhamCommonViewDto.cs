using System;
using System.Collections.Generic;
using ThuongMaiDienTuAPI.Entities;

namespace ThuongMaiDienTuAPI.Dtos
{
    public class SanPhamCommonViewDto
    {
        public int IdSanPham { get; set; }
        public int IdCauHinh { get; set; }
        public int IdDanhMuc { get; set; }
        public int IdSeller { get; set; }
        public string Mota { get; set; }
        public int? ThoiGianBH { get; set; }
        public int? SLXem { get; set; }
        public bool? CoSPHome { get; set; }
        public bool? CoSPHot { get; set; }
        public DateTime NgayTao { get; set; }
        public bool? TrangThai { get; set; }
        public string TenSP { get; set; }
        public string TenKhac { get; set; }
        public string NoiDung { get; set; }
        public string Hinh { get; set; }
        public string HinhCT { get; set; }
        public bool? TinhTrangHang { get; set; }
        public CauHinh CauHinh { get; set; }
        public List<PhanLoaiSPCommonViewDto> PhanLoaiSP { get; set; }
    }
}
