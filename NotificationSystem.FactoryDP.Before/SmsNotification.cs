using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem.FactoryDP.Before
{
    public class SmsNotification
    {
        public void Notify(string message) => Console.WriteLine("Sending Sms Notification: " + message);
    }
}
