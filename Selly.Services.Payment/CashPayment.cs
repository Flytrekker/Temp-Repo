using System;

namespace Selly.Services.Payment
{
    public class CashPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Paid Via Cash Payment");                
        }
    }
}
