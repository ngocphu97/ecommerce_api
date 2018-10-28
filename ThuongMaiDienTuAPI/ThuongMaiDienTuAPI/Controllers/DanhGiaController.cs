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
    public class DanhGiaController : Controller
    {
        private IDanhGiaService danhGiaService;
        private IMapper mapper;
        public DanhGiaController(IDanhGiaService danhGiaService, IMapper mapper)
        {
            this.danhGiaService = danhGiaService;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get([FromQuery] DanhGiaQuery query)
        {
            return Ok(await danhGiaService.Get(query));
        }
    }
}