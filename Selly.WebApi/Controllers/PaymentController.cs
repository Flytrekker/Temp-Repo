using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Selly.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController: ControllerBase
    {
        // POST api/values
        [HttpPost]
        public void Post()
        {
            PayViaCash();
            PayViaPayPayl();

        }
        private void PayViaCash()
        { }
        private void PayViaPayPayl()
        { }
    }
}
