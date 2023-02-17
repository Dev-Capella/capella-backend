using API.Utilities.ResponseData;
using Application.Services;
using Application.Services.Permission;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistence.Services;
using Persistence.Services.Permission;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
       
        private readonly IPermissionService _permissionService;
        private readonly ILogger<PermissionController> _logger;
        public PermissionController(IPermissionService permissionService, ILogger<PermissionController> logger)
        {
            _permissionService = permissionService;
            _logger = logger;
        }
        [HttpGet("/permission")]
        public async Task<IActionResult> GetPermission()
        {
            _logger.LogInformation("Inside GetRoles of RoleController");
            var permission = await _permissionService.GetAllPermission();
            var response = new ServiceResponseData
            {
                Status = ProcessStatus.SUCCESS,
                Data = permission
            };
            return Ok(response);
        }
    }
}
