using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using ThuongMaiDienTuAPI.Interfaces;
using ThuongMaiDienTuAPI.Dtos;
using ThuongMaiDienTuAPI.Dtos.Queries;
namespace ThuongMaiDienTuAPI.Controllers
{
    [Route("api/[controller]")]
    public class ThongKeHoaDonController : Controller
    {
        private IThongKeHoaDonService thongKeHoaDonService;
        private IMapper mapper;
        public ThongKeHoaDonController(IThongKeHoaDonService thongKeHoaDonService, IMapper mapper)
        {
            this.thongKeHoaDonService = thongKeHoaDonService;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get([FromQuery] ThongKeHoaDonQuery query)
        {
            return Ok(await thongKeHoaDonService.Get(query));
        }
    }
}