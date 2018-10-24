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
    [Authorize]
    public class SanPhamController : Controller
    {
        private ISanPhamService sanPhamService;
        private IMapper mapper;
        public SanPhamController(ISanPhamService sanPhamService, IMapper mapper)
        {
            this.sanPhamService = sanPhamService;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("get")]
        [AllowAnonymous]
        public async Task<IActionResult> Get([FromQuery]SanPhamQuery query)
        {
            return Ok(await sanPhamService.Get(query));
        }
    }
}