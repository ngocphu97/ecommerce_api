using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThuongMaiDienTuAPI.Dtos
{
    public class UserDto
    {
        public int IdUser { get; set; }
        public string TenDN { get; set; }
        public string TrangThai { get; set; }
        public string LoaiUser { get; set; }
    }
}
