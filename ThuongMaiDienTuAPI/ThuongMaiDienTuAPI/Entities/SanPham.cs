using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Entities
{
    public class SanPham
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Ten { get; set; }
        [Required]
        [MaxLength(256)]
        public string TenKhac { get; set; }

        public int? IdCauHinh { get; set; }
        public int IdDanhMuc { get; set; }
        public int IdSeller { get; set; }

        [MaxLength(500)]
        public string Mota { get; set; }
        public string NoiDung { get; set; }
        [MaxLength(256)]
        public string Hinh { get; set; }
        [DataType("xml")]
        public string HinhCT { get; set; }
        public string ThoiGianBH { get; set; }
        public int SLXem { get; set; }
        public bool? CoSPHome { get; set; }
        public bool? CoSPHot { get; set; }
        public DateTime NgayTao { get; set; }
        public bool TrangThai { get; set; }
        public string TinhTrangHang { get; set; }

        public CauHinh CauHinh { get; set; }
        public List<PhanLoaiSP> PhanLoaiSP { get; set; }
    }
}
