using API.Utilities.ResponseData;
using Application.DataTransferObject;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService _supplierService;
        private readonly ILogger<SupplierController> _logger;
        public SupplierController(ISupplierService supplierService, ILogger<SupplierController> logger)
        {
            _supplierService = supplierService;
            _logger = logger;
        }

        [HttpPost("/suppliers")]
        public async Task<IActionResult> Save([FromBody] SupplierDto supplierDto)
        {
            _logger.LogInformation("Inside Save of SupplierController", supplierDto);
            await _supplierService.Save(supplierDto);
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS
            };
            return Ok(response);
        }

        [HttpGet("/suppliers/{code}")]
        public async Task<ActionResult> GetSupplierByCode([FromRoute] string code)
        {
            _logger.LogInformation("Inside GetSupplierByCode of SupplierController", code);
            var supplier = await _supplierService.GetSupplierByCode(code);
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS,
                Data = supplier

            };
            return Ok(response);
        }

        [HttpPut("/suppliers")]
        public async Task<IActionResult> Update([FromBody] SupplierDto supplierDto)
        {
            _logger.LogInformation("Inside Update of SupplierController", supplierDto);
            await _supplierService.Update(supplierDto);
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS

            };
            return Ok(response);

        }

        [HttpDelete("/suppliers/{code}")]
        public async Task<IActionResult> Delete(string code)
        {
            _logger.LogInformation("Inside Delete of SupplierController", code);
            await _supplierService.Delete(code);
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS

            };
            return Ok(response);

        }

        [HttpGet("/suppliers")]
        public async Task<IActionResult> GetSuppliers()
        {
            _logger.LogInformation("Inside GetSuppliers of SupplierController");
            var suppliers = await _supplierService.GetAllSuppliers();
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS,
                Data = suppliers
            };
            return Ok(response);
        }
    }
}
