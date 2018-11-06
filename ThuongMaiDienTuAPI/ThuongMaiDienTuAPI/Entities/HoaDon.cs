using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Entities
{
    public class HoaDon
    {
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
        public ICollection<ChiTietHD> ChiTietHD { get; set; } = new HashSet<ChiTietHD>();
    }
}
