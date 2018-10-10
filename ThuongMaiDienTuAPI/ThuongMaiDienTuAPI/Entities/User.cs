using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThuongMaiDienTuAPI.Entities
{
    public class User
    {
        public int IdUser { get; set; }
        public string TenDN { get; set; }
        public string Matkhau { get; set; }
        public string TrangThai { get; set; }
    }
}
