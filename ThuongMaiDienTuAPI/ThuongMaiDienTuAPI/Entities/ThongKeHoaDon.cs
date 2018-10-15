using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Entities
{
    public class ThongKeHoaDon
    {
        public int IdHoaDon { get; set; }
        public int IdSeller { get; set; }
        public int TongTien { get; set; }
        public int TongTienGoc { get; set; }
    }
}
