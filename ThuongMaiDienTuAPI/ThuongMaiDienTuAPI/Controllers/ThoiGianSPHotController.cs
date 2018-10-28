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
    public class ThoiGianSPHotController : Controller
    {
        private IThoiGianSPHotService thoiGianSPHotService;
        private IMapper mapper;
        public ThoiGianSPHotController(IThoiGianSPHotService thoiGianSPHotService, IMapper mapper)
        {
            this.thoiGianSPHotService = thoiGianSPHotService;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get([FromQuery] ThoiGianSPHotQuery query)
        {
            return Ok(await thoiGianSPHotService.Get(query));
        }
    }
}