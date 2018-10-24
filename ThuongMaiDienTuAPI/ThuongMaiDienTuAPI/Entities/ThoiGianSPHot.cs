using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Entities
{
    public class ThoiGianSPHot
    {
        [Key]
        public int IdSanPham { get; set; }
        public DateTime ThoiGianBD { get; set; }
        public DateTime ThoiGianKT { get; set; }
    }
}
