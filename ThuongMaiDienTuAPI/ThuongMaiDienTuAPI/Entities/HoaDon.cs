using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Entities
{
    public class HoaDon
    {
        public HoaDon()
        {
            ChiTietHD = new HashSet<ChiTietHD>();
        }
        public HoaDon(HoaDon hoaDon)
        {
            Ngay = hoaDon.Ngay;
            TrangThai = hoaDon.TrangThai;
            IdUser = hoaDon.IdUser;
            DiaChiKH = hoaDon.DiaChiKH;
            GhiChu = hoaDon.GhiChu;
            TenKH = hoaDon.TenKH;
            Mail = hoaDon.Mail;
            SDT = hoaDon.SDT;
            PhuongThucTT = hoaDon.PhuongThucTT;
            TinhTrangTT = hoaDon.TinhTrangTT;
            ChiTietHD = new HashSet<ChiTietHD>();
        }
        [Key]
        public int IdHoaDon { get; set;  }
        public DateTime Ngay { get; set; }
        public int TongTien { get; set; }
        public bool TrangThai { get; set; }
        public int? IdUser { get; set; }
        public string DiaChiKH { get; set; }
        [MaxLength(150)]
        public string GhiChu { get; set; }
        [MaxLength(100)]
        public string TenKH { get; set; }
        public int IdSeller { get; set; }
        //DiaChiKH? & DiaChi string?
        [MaxLength(50)]
        [EmailAddress]
        public string Mail { get; set; }
        [MaxLength(13)]
        [Phone]
        public string SDT { get; set; }
        [MaxLength(50)]
        public string PhuongThucTT { get; set; }
        [MaxLength(20)]
        public string TinhTrangTT { get; set; }
        public ICollection<ChiTietHD> ChiTietHD { get; set; }
    }
}
