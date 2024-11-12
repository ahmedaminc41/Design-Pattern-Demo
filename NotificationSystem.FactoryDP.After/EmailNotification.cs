using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem.FactoryDP.After
{
    public class EmailNotification : INotification
    {
        public void Notify(string message) => Console.WriteLine("Sending Email Notification: " + message);
    }
}
