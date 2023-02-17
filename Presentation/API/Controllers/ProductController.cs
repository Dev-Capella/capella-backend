using API.Filters;
using API.Utilities.ResponseData;
using Application.DataTransferObject;
using Application.Repositories.ProductAbstract;
using Application.Services;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductController> _logger;
       
        public ProductController(IProductService productService, ILogger<ProductController> logger)
        {
            _productService = productService;
            _logger = logger;
        }

        [HttpPost("/products")]
        //[ServiceFilter(typeof(CustomAuthorizationFilter)), PermissionAttribute("product_added")]
        [RequestSizeLimit(100_000_000)]
        public async Task<IActionResult> AddProduct([FromBody] ProductDto productDto)
        {
            _logger.LogInformation("Inside Save of ProductController", productDto);
            await _productService.Save(productDto);
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS
            };
            return Ok(response);

        }

        [HttpGet("/products")]
        public async Task<IActionResult> GetProducts()
        {
            _logger.LogInformation("Inside GetProducts of ProductController");
            var products = await _productService.GetAllProducts();
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS,
                Data = products
            };
            return Ok(response);
        }

        [HttpGet("/products/{code}")]
        public async Task<IActionResult> GetProductByCode(string code)
        {
            _logger.LogInformation("Inside GetProductByCode of ProductController",code);
            var product = await _productService.GetProductByCode(code);
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS,
                Data = product
            };
            return Ok(response);
        }

        [HttpPut("/products")]
        public async Task<IActionResult> Update([FromBody] ProductDto productDto)
        {
            _logger.LogInformation("Inside Update of ProductController", productDto);
            await _productService.Update(productDto);
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS

            };
            return Ok(response);

        }

        [HttpDelete("/products/{code}")]
        public async Task<IActionResult> Delete(string code)
        {
            _logger.LogInformation("Inside Delete of ProductController", code);
            await _productService.Delete(code);
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS

            };
            return Ok(response);

        }
    }
}
