using API.Utilities.ResponseData;
using Application.DataTransferObject;
using Application.Services;
using Application.Services.DataImport;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataImportController : ControllerBase
    {
        private readonly IDataImportService _dataImportService;
        private readonly ILogger<DataImportController> _logger;
        public DataImportController(IDataImportService dataImportService,ILogger<DataImportController> logger)
        {  
            _dataImportService = dataImportService;
            _logger = logger;
        }

        [HttpGet("capella-models")]
        public IActionResult GetEntityNames()
        {
            var entityNames = _dataImportService.GetEntityNames();

            return Ok(entityNames);
        }

        [HttpPost("import")]
        public IActionResult DataImport([FromBody] DataImportDto dataImportDto)
        {
            var entityNames = _dataImportService.GetEntityNames();

            return Ok(entityNames);
        }
    }
}
