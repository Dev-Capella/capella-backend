using API.Utilities.ResponseData;
using Application.DataTransferObject;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        private readonly IMediaService _mediaService;
        private readonly ILogger<MediaController> _logger;

        public MediaController(IMediaService mediaService,ILogger<MediaController> logger)
        {
            _mediaService = mediaService;
            _logger = logger;
        }

        [HttpPost("/media/content-category")]

        public async Task<ActionResult> Save([FromForm] MediaFormDto mediaFormDto)
        {
            _logger.LogInformation("Inside Save of MediaController", mediaFormDto.Code);
            var medias = await _mediaService.Save(mediaFormDto.Medias, mediaFormDto.Code, true);
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS,
                Data = medias

            };
            return Ok(response);
        }

    }
}
