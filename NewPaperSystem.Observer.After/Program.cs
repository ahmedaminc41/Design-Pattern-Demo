using NewPaperSystem.Observer.Before;

namespace NewPaperSystem.Observer.After
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher("ABC");

            Subscriber S01 = new Subscriber("Ahmed Amin");
            Subscriber S02 = new Subscriber("Mohamed Gamal");
            Subscriber S03 = new Subscriber("Ziad Fathy");
            VIPSubscriber vIP01 = new VIPSubscriber("Ahmed Ali");
            publisher.Subscribe(S01);
            publisher.Subscribe(S02);
            publisher.Subscribe(S03);
            publisher.Subscribe(vIP01);


            publisher.PublishArticle("Breaking News: Observer DP in Action !");

            Console.WriteLine("========================");


            publisher.Unsubscribe(S03);

            publisher.PublishArticle("Second Article : DP in C# is in Action !");
        }
    }
}
