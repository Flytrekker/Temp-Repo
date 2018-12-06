using System;

namespace Selly.Services.Payment
{
    public class PayPalPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Paid Via Cash PayPal");
        }
    }
}
