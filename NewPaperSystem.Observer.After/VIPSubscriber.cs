using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPaperSystem.Observer.After
{
    internal class VIPSubscriber : IObserver
    {
        private readonly string _name;

        public VIPSubscriber(string name)
        {
            _name = name;
        }


        public void Update(string message)
        {
            Console.WriteLine($"{_name} received notification: {message}");

        }
    }
}
