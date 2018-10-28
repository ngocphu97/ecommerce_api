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
    public class ThongBaoController : Controller
    {
        private IThongBaoService thongBaoService;
        private IMapper mapper;
        public ThongBaoController(IThongBaoService thongBaoService, IMapper mapper)
        {
            this.thongBaoService = thongBaoService;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get([FromQuery] ThongBaoQuery query)
        {
            return Ok(await thongBaoService.Get(query));
        }
    }
}