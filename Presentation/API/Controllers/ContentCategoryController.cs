using API.Utilities.ResponseData;
using Application.DataTransferObject;
using Application.Services.ContentCategory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentCategoryController : ControllerBase
    {
        private readonly IContentCategoryService _contentCategoryService;
        private readonly ILogger<ContentCategoryDto> _logger;
        public ContentCategoryController(IContentCategoryService contentCategoryService,ILogger<ContentCategoryDto> logger)
        {
            _contentCategoryService = contentCategoryService;
            _logger = logger;
        }

        [HttpPost("/content-category")]
        public async Task<IActionResult> Save([FromBody]  ContentCategoryDto contentCategoryDto)
        {
            _logger.LogInformation("Inside Save of ContentCategoryController", contentCategoryDto);
            await _contentCategoryService.Save(contentCategoryDto);
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS
            };
            return Ok(response);
        }
        [HttpGet("/content-category/{code}")]
        public async Task<ActionResult> GetContentCategoryByCode([FromRoute] string code)
        {
            _logger.LogInformation("Inside GetContentCategoryByCode of ContentCategoryController", code);
            var contentCategory = await _contentCategoryService.GetContentCategoryByCode(code);
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS,
                Data = contentCategory

            };
            return Ok(response);
        }

        [HttpPut("/content-category")]
        public async Task<IActionResult> Update([FromBody] ContentCategoryDto contentCategoryDto)
        {
            _logger.LogInformation("Inside Update of ContentCategoryController", contentCategoryDto);
            await _contentCategoryService.Update(contentCategoryDto);
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS

            };
            return Ok(response);

        }

        [HttpDelete("/content-category/{code}")]
        public async Task<IActionResult> Delete(string code)
        {
            _logger.LogInformation("Inside Delete of ContentCategoryController", code);
            await _contentCategoryService.Delete(code);
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS

            };
            return Ok(response);

        }

        [HttpGet("/content-category")]
        public async Task<IActionResult> GetContentCategories()
        {
            _logger.LogInformation("Inside GetContentCategories of ContentCategoryController");
            var contentCategories = await _contentCategoryService.GetAllContentCategories();
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS,
                Data = contentCategories
            };
            return Ok(response);
        }

    }
}
