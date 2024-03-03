using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MailKit;
using MimeKit;
using MimeKit.Text;
using MailKit.Net.Smtp;
using MailKit.Security;
using Himsug_Final4.Shared.Models;
using EmailDto = Himsug_Final4.Shared.Models.EmailDto;

namespace Himsug_Final4.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendController : ControllerBase
    {
        private readonly IEmailservice _emailservice;

        public SendController(IEmailservice emailservice)
        {
            _emailservice = emailservice;
        }

        [HttpGet]
        public IActionResult SendEmail(EmailDto request)
        {
            try
            {
                _emailservice.SendEmail(request);

                return Ok("Email Sent");
            }

            catch (Exception ex)
            {

                return StatusCode(500, $"Internal Error : Something went wrong, check the code" + ex.Message);
            }


        }
    }
}
