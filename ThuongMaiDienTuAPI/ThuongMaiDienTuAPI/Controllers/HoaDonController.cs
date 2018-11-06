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
        [Route("getbyuser")]
        public async Task<IActionResult> GetByUser([FromQuery] HoaDonQuery query)
        {
            int idCustomer = int.Parse(User.Claims.FirstOrDefault(x => x.Type == "IdUser").Value);
            return Ok(await hoaDonService.GetByCustomer(idCustomer,query));
        }
        [HttpGet]
        [Route("getbyseller")]
        public async Task<IActionResult> GetBySeller([FromQuery] HoaDonQuery query)
        {
            int idSeller = int.Parse(User.Claims.FirstOrDefault(x => x.Type == "IdSeller").Value);
            return Ok(await hoaDonService.GetBySeller(idSeller, query));
        }
    }
}