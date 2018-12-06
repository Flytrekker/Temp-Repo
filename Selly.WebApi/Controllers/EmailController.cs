using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Selly.WebApi.Controllers
{
    [Route("Email")]
    [ApiController]
    public class EmailController : ControllerBase
    {

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
        { }
        private void SendEmailViaSmtp()
        { }
    }
}
