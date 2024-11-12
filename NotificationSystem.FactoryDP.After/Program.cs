namespace NotificationSystem.FactoryDP.After
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter notification channel (email/sms): ");
            var channel = Console.ReadLine();

            Console.Write("Enter Message: ");
            var message = Console.ReadLine();


            var notification = NotificationFactory.CreateNotification(channel);

            notification.Notify(message);

        }
    }
}
