using API.Utilities.ResponseData;
using Application.DataTransferObject;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;
        private readonly ILogger<AddressController> _logger;
        public AddressController(IAddressService addressService, ILogger<AddressController> logger)
        {
            _addressService = addressService;
            _logger = logger;
        }

        [HttpPost("/address")]
        public async Task<IActionResult> Save([FromBody] AddressDto addressDto)
        {
            _logger.LogInformation("Inside Save of AddressController", addressDto);
            await _addressService.Save(addressDto);
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS
            };
            return Ok(response);

        }

        [HttpGet("/countries")]
        public async Task<IActionResult> GetCountries()
        {
            _logger.LogInformation("Inside GetCountries of AddressController");
            var countries = await _addressService.GetAllCountries();
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS,
                Data = countries
            };
            return Ok(response);
        }

        [HttpGet("/countries/{code}/cities")]
        public async Task<ActionResult> GetCitiesByCountryCode([FromRoute] string code)
        {
            _logger.LogInformation("Inside GetCitiesByCountryCode of AddressController", code);
            var cities = await _addressService.GetCitiesByCountryCode(code);
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS,
                Data = cities

            };
            return Ok(response);
        }

        [HttpGet("/cities/{code}/districts")]
        public async Task<ActionResult> GetDistrictsByCityCode([FromRoute] string code)
        {
            _logger.LogInformation("Inside GetDistrictsByCityCode of AddressController", code);
            var districts = await _addressService.GetDistrictsByCityCode(code);
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS,
                Data = districts

            };
            return Ok(response);
        }
    }
}
