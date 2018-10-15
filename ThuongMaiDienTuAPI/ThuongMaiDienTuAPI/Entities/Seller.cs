using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Entities
{
    public class Seller
    {
        [Key]
        public int IdSeller { get; set; }
        public int IdUser { get; set; }
        [MaxLength(20)]
        public string CMND { get; set; }
        [MaxLength(50)]
        [EmailAddress]
        public string Mail { get; set; }
        public bool CheckMail { get; set; }
        public bool CheckCMND { get; set; }
        public DateTime NgayDK { get; set; }
        public DiaChi DiaChi { get; set; }
        [MaxLength(100)]
        public string TenSeller { get; set; }
    }
}
