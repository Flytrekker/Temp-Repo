using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Selly.Services;

namespace Selly.WebApi.Controllers
{

    [Route("Email")]
    [ApiController]
    public class EmailController : ControllerBase
    {

        private readonly IGmailService _gmail;
        private readonly ISmtpService _smtp;

        public EmailController(IGmailService gmail, ISmtpService smtp)
        {
            _gmail = gmail;
            _smtp = smtp;
        }

        // POST api/values
        [HttpPost]
        public void Post()
        {
            
        }


        //UI will call this method via http://<uri>/Email/SendGmail

        [Route("SendGmail")]
        public void PostSendGmail()
        {
            SendEmailViaGmail();
        }


        //UI will call this method via http://<uri>/Email/SendSmtp
        [Route("SendSmtp")]
        public void PostSendSmtp()
        {
            SendEmailViaSmtp();
        }

        private void SendEmailViaGmail()
        {
            _gmail.SendMail();
        }
        private void SendEmailViaSmtp()
        {
            _smtp.SendMail();
        }
    }
}
