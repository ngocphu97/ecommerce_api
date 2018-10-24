using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Entities
{
    public class Page
    {
        [Key]
        public int IdPage { get; set; }
        public string TenPage { get; set; }
        public string TenKhac { get; set; }
        public string NoiDung { get; set; }
        public bool TinhTrang { get; set; }
    }
}
