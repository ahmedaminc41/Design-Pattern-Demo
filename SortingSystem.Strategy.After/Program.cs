
namespace SortingSystem.Strategy.After
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 34, 43, 2, 7, 62, 5 };

            Console.Write("Enter sorting algorithm (bubble/quick/insertion): ");
            var algo = Console.ReadLine();


            Console.WriteLine("Original Array: " + string.Join(", ", array));

            ISortStrategy sortStrategy = SortingFactory.CreateSortStrategy(algo);

            Sorter sorter = new Sorter(sortStrategy);

            sorter.Sort(array);

            Console.WriteLine("Sorted Array: " + string.Join(", ", array));
        }
    }
}
