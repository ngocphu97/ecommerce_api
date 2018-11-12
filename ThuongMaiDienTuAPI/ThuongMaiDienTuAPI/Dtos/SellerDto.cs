using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Dtos
{
    public class SellerDto
    {
        [MaxLength(100)]
        public string TenSeller { get; set; }
        [MaxLength(20)]
        public string CMND { get; set; }
        [MaxLength(50)]
        [EmailAddress]
        public string Mail { get; set; }
        public DiaChiDto DiaChi { get; set; }
    }
}
