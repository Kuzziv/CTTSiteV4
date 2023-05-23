using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using CTTSite.Services.Interface;
using CTTSite.Models;

namespace CTTSite.Controller
{
	// Made by Christian

	[Route("api/[controller]")]
	[ApiController]
	public class EmailController : ControllerBase
	{
		private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }


        [HttpPost]
		public IActionResult SendEmail(Email request)
		{
			_emailService.SendEmail(request);

			return Ok();
		}
	}
}
