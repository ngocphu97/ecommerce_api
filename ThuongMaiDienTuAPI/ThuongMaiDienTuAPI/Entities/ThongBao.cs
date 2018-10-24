using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Entities
{
    public class ThongBao
    {
        [Key]
        public int IdThongBao { get; set; }
        public int IdUser { get; set; }
        public DateTime Ngay { get; set; }
        public string NoiDung { get; set; }
        public string Link { get; set; }
        public string TinhTrang { get; set; }
    }
}
