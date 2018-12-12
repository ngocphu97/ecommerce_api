using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThuongMaiDienTuAPI.Entities
{
    public class KhuyenMai
    {
        public KhuyenMai()
        {
            this.ChiTietKM = new HashSet<ChiTietKhuyenMai>();
        }
        [Key]
        public int IdKhuyenMai { get; set; }
        [MaxLength(256)]
        [Required]
        public string Ten { get; set; }
        public int IdNguoiTao { get; set; }
        public double PhamTramKM { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public bool TinhTrang { get; set; }
        [MaxLength(50)]
        public string LoaiKhuyenMai { get; set; }
        public ICollection<ChiTietKhuyenMai> ChiTietKM { get; set; }

    }
}
