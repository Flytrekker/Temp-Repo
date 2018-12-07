using System;

namespace Selly.Services.Email
{
    public class SmtpEmailService : ISmtpService
    {
        public void SendMail()
        {
            Console.WriteLine("Sent Via Smtp Email");
        }
    }
}
