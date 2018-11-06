using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Dtos
{
    public class CauHinhDto
    {
        [Required]
        public string ThuongHieu { get; set; }
        [Required]
        public string BoNho { get; set; }
        [Required]
        public string Mang { get; set; }
        [Required]
        public string Sim { get; set; }
        [Required]
        public string ChongThamNuoc { get; set; }
        [Required]
        public string KTManHinh { get; set; }
        [Required]
        public string HeDieuHanh { get; set; }
        [Required]
        public string Ram { get; set; }
        [Required]
        public string CMRTruoc { get; set; }
        [Required]
        public string CMRSau { get; set; }
        [Required]
        public string GPS { get; set; }
        [Required]
        public string Bluetooth { get; set; }
        [Required]
        public string Pin { get; set; }
    }
}
