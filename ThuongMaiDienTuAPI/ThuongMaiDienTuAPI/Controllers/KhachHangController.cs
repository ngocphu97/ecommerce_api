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
    [Authorize]
    [Route("api/[controller]")]
    public class KhachHangController : Controller
    {
        private IKhachHangService khachHangService;
        private IMapper mapper;
        public KhachHangController(IKhachHangService khachHangService, IMapper mapper)
        {
            this.khachHangService = khachHangService;
            this.mapper = mapper;
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get([FromQuery] KhachHangQuery query)
        {
            return Ok(await khachHangService.Get(query));
        }
    }
}