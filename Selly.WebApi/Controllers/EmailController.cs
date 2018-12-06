using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Selly.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        public void Post()
        {
            SendEmailViaGmail();
            SendEmailViaSmtp();
        }
        private void SendEmailViaGmail()
        { }
        private void SendEmailViaSmtp()
        { }
    }
}
