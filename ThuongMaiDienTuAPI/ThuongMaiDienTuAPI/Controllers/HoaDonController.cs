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
    public class HoaDonController : Controller
    {
        private IHoaDonService hoaDonService;
        private IMapper mapper;
        public HoaDonController(IHoaDonService hoaDonService, IMapper mapper)
        {
            this.hoaDonService = hoaDonService;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get([FromQuery] HoaDonQuery query)
        {
            return Ok(await hoaDonService.Get(query));
        }
    }
}