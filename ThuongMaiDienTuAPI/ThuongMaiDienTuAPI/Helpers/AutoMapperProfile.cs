﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuongMaiDienTuAPI.Entities;
using ThuongMaiDienTuAPI.Dtos;
namespace ThuongMaiDienTuAPI.Helpers
{
    /// <summary>
    /// Mapping Dtos classes and Entities classes
    /// </summary>
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User,UserDto>();
            CreateMap<UserDto,User>();
            CreateMap<DanhMucSP, DanhMucSPDto>();
            CreateMap<DanhMucSPDto, DanhMucSP>();
            CreateMap<DiaChi, DiaChiDto>();
            CreateMap<DiaChiDto, DiaChi>();
            CreateMap<RegisterDto, User>();
            CreateMap<RegisterDto, KhachHang>();
        }
    }
}
