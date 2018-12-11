using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Entities
{
    public class Slide
    {
        [Key]
        public int Id{ get; set; }
        [MaxLength(256)]
        public string Hinh { get; set; }
        public string NoiDung { get; set; }
        [MaxLength(256)]
        public string URL { get; set; }
        public bool TrangThai { get; set; }
    }
}
