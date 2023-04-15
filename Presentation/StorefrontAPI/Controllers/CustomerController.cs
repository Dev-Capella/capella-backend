using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Services.Mail;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StorefrontAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMailService _mailService;

        public CustomerController(IMailService mailService)
        {
            _mailService = mailService;
        }
        
        [HttpGet("/mail")]
        public async Task<IActionResult> ExampleMailTest()
        {
            await _mailService.SendMessageAsync(new[] { "mahmutcopoglu@gmail.com","omerfrkgrsy@gmail.com","onurcopoglu@gmail.com" }, "mail tests", "<b>Bu bir örnek maildir</b>");
            return Ok();
        }
    }
}
