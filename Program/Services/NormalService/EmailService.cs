using CTTSite.Models;
using CTTSite.Services.Interface;
using MimeKit;

namespace CTTSite.Services.NormalService
{
	/// <summary>
	/// This class is used to send emails to the desired recipient
	/// </summary>
	public class EmailService : IEmailService
	{
		// Made by Christian

		private readonly IConfiguration _config;

		public EmailService(IConfiguration config) 
		{ 
		     _config = config;
		}

		/// <summary>
		/// Sends an email to the desired recipient
		/// </summary>
		/// <param name="request"></param>
		public void SendEmail(Email request)
		{
			var email = new MimeMessage();
			email.From.Add(MailboxAddress.Parse("CTT_Test2@outlook.com")); // Add your email address
			email.To.Add(MailboxAddress.Parse(request.To)); // Add the recipient's email address
			email.Subject = request.Subject; // Add the subject of the email
			email.Body = new TextPart(MimeKit.Text.TextFormat.Plain) { Text = request.Body }; // Add the body of the email

			using var smtp = new MailKit.Net.Smtp.SmtpClient();
			smtp.Connect(_config.GetSection("EmailHost").Value, 587, MailKit.Security.SecureSocketOptions.StartTls); // Add your email provider
			smtp.Authenticate(_config.GetSection("EmailUserName").Value, _config.GetSection("EmailPassword").Value); // Add your email address and password
			smtp.Send(email); // Send the email
			smtp.Disconnect(true); // Disconnect from the email provider
		}
	}
}
