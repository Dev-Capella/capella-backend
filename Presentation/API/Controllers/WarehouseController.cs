using API.Utilities.ResponseData;
using Application.DataTransferObject;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        private readonly IWarehouseService _warehouseService;
        private readonly ILogger<WarehouseController> _logger;
        public WarehouseController(IWarehouseService warehouseService, ILogger<WarehouseController> logger)
        {
            _warehouseService = warehouseService;
            _logger = logger;
        }

        [HttpPost("/warehouses")]
        public async Task<IActionResult> Save([FromBody] WarehouseDto warehouseDto)
        {
            _logger.LogInformation("Inside Save of WarehouseController", warehouseDto);
            await _warehouseService.Save(warehouseDto);
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS
            };
            return Ok(response);
        }

        [HttpGet("/warehouses/{code}")]
        public async Task<ActionResult> GetWarehouseByCode([FromRoute] string code)
        {
            _logger.LogInformation("Inside GetWarehouseByCode of WarehouseController", code);
            var warehouse = await _warehouseService.GetWarehouseByCode(code);
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS,
                Data = warehouse

            };
            return Ok(response);
        }

        [HttpPut("/warehouses")]
        public async Task<IActionResult> Update([FromBody] WarehouseDto warehouseDto)
        {
            _logger.LogInformation("Inside Update of WarehouseController", warehouseDto);
            await _warehouseService.Update(warehouseDto);
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS

            };
            return Ok(response);

        }

        [HttpDelete("/warehouses/{code}")]
        public async Task<IActionResult> Delete(string code)
        {
            _logger.LogInformation("Inside Delete of WarehouseController", code);
            await _warehouseService.Delete(code);
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS

            };
            return Ok(response);

        }

        [HttpGet("/warehouses")]
        public async Task<IActionResult> GetWarehouses()
        {
            _logger.LogInformation("Inside GetWarehouses of WarehouseController");
            var warehouses = await _warehouseService.GetAllWarehouses();
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS,
                Data = warehouses
            };
            return Ok(response);
        }
    }
}
