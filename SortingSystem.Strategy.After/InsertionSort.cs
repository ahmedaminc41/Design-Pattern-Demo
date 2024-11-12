using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingSystem.Strategy.After
{
    public class InsertionSort : ISortStrategy
    {
        public void Sort(int[] array)
        {
            Console.WriteLine("Using Insertion Sort");
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;

                // Move elements of array[0..i-1], that are greater than key, to one position ahead of their current position
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }
    }
}
