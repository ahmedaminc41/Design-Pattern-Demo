namespace PaymentSystem.Adaptor.Before
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessor paymentProcessor = new LocalPaymentProcessor();
            ThirdPartyPaymentGateway thirdPartyPayment = new ThirdPartyPaymentGateway();


            PaymentService paymentService = new PaymentService(thirdPartyPayment);

            paymentService.Pay(100, "USD");
        }
    }
}
