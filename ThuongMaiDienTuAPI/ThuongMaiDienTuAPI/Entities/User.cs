using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Entities
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }
        [MaxLength(100)]
        public string TenDN { get; set; }
        [MaxLength(100)]
        public string Matkhau { get; set; }
        public bool TrangThai { get; set; }
        [MaxLength(20)]
        public string LoaiUser { get; set; }
    }
}
