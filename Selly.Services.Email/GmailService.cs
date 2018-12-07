using System;

namespace Selly.Services.Email
{
    public class GmailService : IGmailService
    {
        public void SendMail()
        {
            Console.WriteLine("Sent Via Gmail");
        }
    }
}
