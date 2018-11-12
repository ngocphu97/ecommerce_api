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
using ThuongMaiDienTuAPI.Entities;
using ThuongMaiDienTuAPI.Helpers;
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
            return Ok(mapper.Map<SanPhamCommonViewDto>(await sanPhamService.Get(query)));
        }
        [HttpGet]
        [Route("getbyseller")]
        [Authorize(Roles ="SELLER")]
        public async Task<IActionResult> GetBySeller([FromQuery]SanPhamQuery query)
        {
            int idSeller = User.GetIdSeller();
            return Ok(await sanPhamService.Get(idSeller, query));
        }

        [HttpPost]
        [Route("add")]
        [Authorize(Roles = "SELLER")]
        public async Task<IActionResult> Add([FromBody]SanPhamDto sanPhamDto)
        {
            int idSeller = User.GetIdSeller();
            if(await sanPhamService.Add(idSeller, mapper.Map<SanPham>(sanPhamDto)))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{idSanPham}")]
        [Route("delete")]
        [Authorize(Roles = "SELLER")]
        public async Task<IActionResult> Delete(int idSanPham)
        {
            int idSeller = User.GetIdSeller();
            if (await sanPhamService.Delete(idSeller, idSanPham))
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{idSanPham}")]
        [Route("block")]
        [Authorize(Roles = "SELLER")]
        public async Task<IActionResult> Block(int idSanPham)
        {
            int idSeller = User.GetIdSeller();
            if (await sanPhamService.Block(idSeller, idSanPham))
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}