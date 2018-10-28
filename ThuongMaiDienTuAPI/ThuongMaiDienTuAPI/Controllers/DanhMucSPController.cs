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
    public class DanhMucSPController : Controller
    {
        private IDanhMucSPService danhMucSPService;
        private IMapper mapper;
        public DanhMucSPController(IDanhMucSPService danhMucSPService, IMapper mapper)
        {
            this.danhMucSPService = danhMucSPService;
            this.mapper = mapper;
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get([FromQuery] DanhMucSPQuery query)
        {
            return Ok(await danhMucSPService.Get(query));
        }
    }
}