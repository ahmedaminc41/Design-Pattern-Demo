namespace NewPaperSystem.Observer.Before
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher("ABC");

            Subscriber S01 = new Subscriber("Ahmed Amin");
            Subscriber S02 = new Subscriber("Mohamed Gamal");
            Subscriber S03 = new Subscriber("Ziad Fathy");

            publisher.AddSubscriber(S01);
            publisher.AddSubscriber(S02);
            publisher.AddSubscriber(S03);


            publisher.PublishArticle("Breaking News: Observer DP in Action !");

            Console.WriteLine("========================");


            publisher.RemoveSubscriber(S03);

            publisher.PublishArticle("Second Article : DP in C# is in Action !");



        }
    }
}
