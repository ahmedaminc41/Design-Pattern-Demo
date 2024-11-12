using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem.Adaptor.After
{
    public class ThirdPartyPaymentAdaptor : IPaymentProcessor
    {
        private readonly ThirdPartyPaymentGateway _thirdPartyPayment;

        public ThirdPartyPaymentAdaptor(ThirdPartyPaymentGateway thirdPartyPayment)
        {
            _thirdPartyPayment = thirdPartyPayment;
        }

        public void ProcessPayment(decimal amount, string currency)
        {
            _thirdPartyPayment.MakePayment(currency, amount);
        }
    }
}
