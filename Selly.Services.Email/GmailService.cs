using System;

namespace Selly.Services.Email
{
    public class GmailService : IEmailService
    {
        public void SendMail()
        {
            Console.WriteLine("Sent Via Gmail");
        }
    }
}
