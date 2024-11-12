using NewPaperSystem.Observer.After;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPaperSystem.Observer.Before
{
    public class Publisher : ISubject
    {

        private readonly string _name;

        public Publisher(string name)
        {
            _name = name;
        }

        private readonly List<IObserver> _subscribers = new List<IObserver>();

        public void Subscribe(IObserver observer) => _subscribers.Add(observer);

        public void Unsubscribe(IObserver observer) => _subscribers.Remove(observer);
       
        public void NotifyObservers(string message)
        {
            foreach (var observer in _subscribers)
            {
                observer.Update(message);
            }
        }


        public void PublishArticle(string articleTitle)
        {
            Console.WriteLine($"Publisher {_name} publishing article - '{articleTitle}'");
            NotifyObservers(articleTitle);
        }

    }
}
