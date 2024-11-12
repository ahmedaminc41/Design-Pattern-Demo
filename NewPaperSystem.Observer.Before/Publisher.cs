using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPaperSystem.Observer.Before
{
    public class Publisher
    {

        private readonly string _name;

        public Publisher(string name)
        {
            _name = name;
        }

        private readonly List<Subscriber> _subscribers = new List<Subscriber>();

        public void AddSubscriber(Subscriber subscriber) => _subscribers.Add(subscriber);
        public void RemoveSubscriber(Subscriber subscriber) => _subscribers.Remove(subscriber);


        public void PublishArticle(string articleTitle)
        {
            Console.WriteLine($"Publisher {_name} publishing article - '{articleTitle}'");

            foreach (var subscriber in _subscribers)
            {
                subscriber.ReceiveNotification(articleTitle);
            }

        }


    }
}
