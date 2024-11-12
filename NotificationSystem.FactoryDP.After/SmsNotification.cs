using NotificationSystem.FactoryDP.After;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem.FactoryDP.After
{
    public class SmsNotification : INotification
    {
        public void Notify(string message) => Console.WriteLine("Sending Sms Notification: " + message);
    }
}
