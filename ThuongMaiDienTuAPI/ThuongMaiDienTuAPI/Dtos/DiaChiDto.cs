using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Dtos
{
    public class DiaChiDto
    {
        [MaxLength(10)]
        public string SoNha { get; set; }
        [MaxLength(50)]
        public string Duong { get; set; }
        [MaxLength(50)]
        public string PhuongXa { get; set; }
        [MaxLength(50)]
        public string QuanHuyen { get; set; }
        [MaxLength(50)]
        public string TinhTP { get; set; }
    }
}
