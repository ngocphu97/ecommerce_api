using System.ComponentModel.DataAnnotations;

namespace ThuongMaiDienTuAPI.Entities
{
    public class LoaiQuangCao
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(56)]
        public string ViTri { get; set; }
        public double Gia { get; set; }
        public bool TinhTrang { get; set; }
    }
}
