using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem.FactoryDP.After
{
    public class NotificationFactory
    {

        public static INotification CreateNotification(string channel)
        {
            if (channel.ToLower() == "email")
            {
                return new EmailNotification();
            }
            else if (channel.ToLower() == "sms")
            {
                return new SmsNotification();
            }
            else
            {
                throw new ArgumentException("Invalid Notification channel !");
            }
        }

    }
}
