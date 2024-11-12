using NewPaperSystem.Observer.After;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPaperSystem.Observer.Before
{
    public class Subscriber : IObserver
    {
        private readonly string _name;

        public Subscriber(string name)
        {
            _name = name;
        }


        public void Update(string message)
        {
            Console.WriteLine($"{_name} received notification: {message}");

        }
    }
}
