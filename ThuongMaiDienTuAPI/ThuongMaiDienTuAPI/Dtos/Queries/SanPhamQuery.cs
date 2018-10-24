using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuongMaiDienTuAPI.Interfaces;
namespace ThuongMaiDienTuAPI.Dtos.Queries
{
    public class SanPhamQuery : IPaging, ISorting
    {
        public string SortBy { get; set; } = "SLXem";
        public string Order { get; set; } = "desc";
        public int PageSize { get; set; } = 20;
        public int Page { get; set; } = 1;

        public string TenSP { get; set; } = null;
        public bool? CoSPHot { get; set; } = null;
        public bool? CoSPHome { get; set; } = null;
        public bool? TrangThai { get; set; } = null;

    }
}
