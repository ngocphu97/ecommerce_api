using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Dtos
{
    public class DanhMucSPDto
    {
        public string TenDM { get; set; }
        public string TenKhac { get; set; }
        public bool TinhTrang { get; set; }
        public string Hinh { get; set; }
    }
}
