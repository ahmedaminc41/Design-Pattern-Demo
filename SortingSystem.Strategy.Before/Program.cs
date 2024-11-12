namespace SortingSystem.Strategy.Before
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 34, 43, 2, 7, 62, 5 };

            Console.Write("Enter sorting algorithm (bubble/quick): ");
            var algo = Console.ReadLine();


            Console.WriteLine("Original Array: " + string.Join(", ", array));

            Sorter sorter = new Sorter();

            sorter.Sort(array, algo);

            Console.WriteLine("Sorted Array: " + string.Join(", ", array));



        }
    }
}
