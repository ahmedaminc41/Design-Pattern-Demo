using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem.Adaptor.Before
{
    public class ThirdPartyPaymentGateway
    {
        public void MakePayment(string currencyCode, decimal paymentAmount)
        {
            Console.WriteLine($"Processing third-party payment of {paymentAmount} {currencyCode}");
        }
    }
}
