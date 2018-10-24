using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Entities
{
    public class DanhMucSP
    {
        [Key]
        public int IdDanhMuc { get; set; }
        public string TenDM { get; set; }
        public string TenKhac { get; set; }
        public bool TinhTrang { get; set; }
        public string Hinh { get; set; }
    }
}
