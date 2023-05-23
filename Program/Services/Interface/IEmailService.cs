using CTTSite.Models;

namespace CTTSite.Services.Interface
{
	public interface IEmailService
	{
		// Made by Christian
		void SendEmail(Email request);
	}
}
