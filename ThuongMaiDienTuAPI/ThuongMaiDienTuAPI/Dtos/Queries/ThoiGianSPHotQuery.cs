﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuongMaiDienTuAPI.Interfaces;
namespace ThuongMaiDienTuAPI.Dtos.Queries
{
    public class ThoiGianSPHotQuery : IPaging, ISorting
    {
        public int PageSize { get; set; } = 20;
        public int Page { get; set; } = 1;
        public string SortBy { get; set; } = "ThoiGianBD";
        public string Order { get; set; } = "desc";
    }
}
