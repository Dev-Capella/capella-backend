using API.Utilities.ResponseData;
using Application.DataTransferObject;
using Application.Services.Banner;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannerController : ControllerBase
    {
        private readonly IBannerService _bannerService;
        private readonly ILogger<BannerController> _logger;
        public BannerController(IBannerService bannerService, ILogger<BannerController> logger)
        {
            _bannerService = bannerService;
            _logger = logger;
        }

        [HttpPost("/banners")]
        public async Task<IActionResult> Save([FromBody] BannerDto bannerDto)
        {
            _logger.LogInformation("Inside Save of BannerController", bannerDto);
            await _bannerService.Save(bannerDto);
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS
            };
            return Ok(response);
        }

        [HttpGet("/banners/{code}")]
        public async Task<ActionResult> GetBannerByCode([FromRoute] string code)
        {
            _logger.LogInformation("Inside GetBannerByCode of BannerController", code);
            var banner = await _bannerService.GetBannerByCode(code);
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS,
                Data = banner

            };
            return Ok(response);
        }

        [HttpPut("/banners")]
        public async Task<IActionResult> Update([FromBody] BannerDto bannerDto)
        {
            _logger.LogInformation("Inside Update of BannerController", bannerDto);
            await _bannerService.Update(bannerDto);
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS

            };
            return Ok(response);

        }

        [HttpDelete("/banners/{code}")]
        public async Task<IActionResult> Delete(string code)
        {
            _logger.LogInformation("Inside Delete of BannerController", code);
            await _bannerService.Delete(code);
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS

            };
            return Ok(response);

        }

        [HttpGet("/banners")]
        public async Task<IActionResult> GetBanners()
        {
            _logger.LogInformation("Inside GetBanners of BannerController");
            var banners = await _bannerService.GetAllBanners();
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS,
                Data = banners
            };
            return Ok(response);
        }
    }
}
