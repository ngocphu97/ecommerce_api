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
    public class SellerController : Controller
    {
        private ISellerService sellerService;
        private IMapper mapper;
        public SellerController(ISellerService sellerService, IMapper mapper)
        {
            this.sellerService = sellerService;
            this.mapper = mapper;
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get([FromQuery] SellerQuery query)
        {
            return Ok(await sellerService.Get(query));
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("getbyiduser")]
        public async Task<IActionResult> GetByIdUser(int idUser)
        {
            return Ok(await sellerService.GetByIdUser(idUser));
        }
    }
}