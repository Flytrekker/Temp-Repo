using System;

namespace Selly.Services.Email
{
    public class SmtpEmailService : IEmailService
    {
        public void SendMail()
        {
            Console.WriteLine("Sent Via Smtp Email");
        }
    }
}
