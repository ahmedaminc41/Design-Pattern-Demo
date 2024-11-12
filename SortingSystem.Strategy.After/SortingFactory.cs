using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingSystem.Strategy.After
{
    internal class SortingFactory
    {

        public static ISortStrategy CreateSortStrategy(string algo)
        {
            if (algo.ToLower() == "bubble")
            {
                return new BubbleSort();
            }
            else if (algo.ToLower() == "quick")
            {
                return new QuickSort();

            }
            else if (algo.ToLower() == "insertion")
            {
                return new InsertionSort();
            }
            else
            {
                throw new ArgumentException("Invalid sort algorithm !");
            }
        }

    }
}
