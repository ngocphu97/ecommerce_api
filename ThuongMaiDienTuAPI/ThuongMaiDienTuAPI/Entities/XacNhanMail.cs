using System.ComponentModel.DataAnnotations;
namespace ThuongMaiDienTuAPI.Entities
{
    public class XacNhanMail
    {
        [Key]
        public int IdUser { get; set; }
        [MaxLength(30)]
        public string Code { get; set; }
    }
}
