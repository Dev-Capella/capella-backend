using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Services.Banner;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StorefrontAPI.Utilities.ResponseData;

namespace StorefrontAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannerController : ControllerBase
    {
        private readonly IBannerService _bannerService;
        
        public BannerController(IBannerService bannerService)
        {
            _bannerService = bannerService;
        }
        
        [HttpGet("/banners")]
        public async Task<IActionResult> GetBanners()
        {
            
            var banners = await _bannerService.GetActiveBanners();
            var response = new ServiceResponseData()
            {
                Status = ProcessStatus.SUCCESS,
                Data = banners
            };
            return Ok(response);
        }
    }
}
