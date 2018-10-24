using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Entities
{
    public class Slide
    {
        [Key]
        public int IdSide { get; set; }
        public string Hinh { get; set; }
        public string NoiDung { get; set; }
        public string URL { get; set; }
        public bool TrangThai { get; set; }
    }
}
