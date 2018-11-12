using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Dtos
{
    public class HoaDonDto
    {
        public int? IdUser { get; set; }
        public string DiaChiKH { get; set; }
        [MaxLength(150)]
        public string GhiChu { get; set; }
        [MaxLength(100)]
        public string TenKH { get; set; }
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
        public ICollection<ChiTietHDDto> ChiTietHD { get; set; } = new HashSet<ChiTietHDDto>();
    }
}
