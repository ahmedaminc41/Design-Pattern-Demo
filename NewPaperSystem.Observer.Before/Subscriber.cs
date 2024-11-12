using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPaperSystem.Observer.Before
{
    public class Subscriber
    {
        private readonly string _name;

        public Subscriber(string name)
        {
            _name = name;
        }


        public void ReceiveNotification(string message)
        {
            Console.WriteLine($"{_name} received notification: {message}");
        }

    }
}
