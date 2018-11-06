using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Dtos
{
    public class RegisterDto
    {
        [MaxLength(100)]
        public string TenKh { get; set; }
        [MaxLength(13)]
        [Phone]
        public string SDT { get; set; }
        public DiaChiDto Diachi { get; set; }
        [MaxLength(50)]
        [EmailAddress]
        public string Mail { get; set; }
        [MaxLength(100)]
        public string TenDN { get; set; }
        [MaxLength(100)]
        public string MatKhau { get; set; }
    }
}
