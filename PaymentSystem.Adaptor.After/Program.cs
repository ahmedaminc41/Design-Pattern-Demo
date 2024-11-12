namespace PaymentSystem.Adaptor.After
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IPaymentProcessor localPaymentProcessor = new LocalPaymentProcessor();
            ThirdPartyPaymentGateway thirdPartyPayment = new ThirdPartyPaymentGateway();
            IPaymentProcessor adaptor = new ThirdPartyPaymentAdaptor(thirdPartyPayment);

            PaymentService paymentService = new PaymentService(adaptor);

            paymentService.Pay(100, "USD");

        }
    }
}
