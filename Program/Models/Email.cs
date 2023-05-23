namespace CTTSite.Models
{
    // Made by Christian
    public class Email
	{
		public string Body { get; set; }
		public string Subject { get; set; }
		public string To { get; set; }

		public Email()
		{
		}

		public Email(string body, string subject, string to)
		{
			Body = body;
			Subject = subject;
			To = to;
		}
	}
}
