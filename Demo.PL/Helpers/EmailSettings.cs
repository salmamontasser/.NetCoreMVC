﻿using DemoDAL.Models;
using System.Net;
using System.Net.Mail;

namespace Demo.PL.Helpers
{
	public static class EmailSettings
	{
		public static void SendEmail(Email email)
		{
			var Client = new SmtpClient("smtp.gmail.com", 587);
			Client.EnableSsl = true;
			Client.Credentials = new NetworkCredential("salmamontasser22@gmail.com", "sxuvcmyketquafsj");
			Client.Send("salmamontasser22@gmail.com",email.To,email.Subject,email.Body);
//			smtp.gmail.com

//Requires SSL: Yes

//Requires TLS: Yes(if available)

//				Requires Authentication: Yes

//				Port for TLS / STARTTLS: 587
		}
	}
}
