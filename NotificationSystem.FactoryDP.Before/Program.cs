namespace NotificationSystem.FactoryDP.Before
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter notification channel (email/sms): ");
            var channel = Console.ReadLine();

            Console.Write("Enter Message: ");
            var message = Console.ReadLine();

            if(channel.ToLower() == "email")
            {
                var notification = new EmailNotification();
                notification.Notify(message);
            }
            else if(channel.ToLower() == "sms")
            {
                var notification = new SmsNotification();
                notification.Notify(message);
            }
            else
            {
                throw new ArgumentException("Invalid Notification channel !");
            }





        }
    }
}
