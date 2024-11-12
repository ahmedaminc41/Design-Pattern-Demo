using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingSystem.Strategy.Before
{
    public class Sorter
    {

        public void Sort(int[] array, string algo)
        {
            if(algo.ToLower() == "bubble")
            {
                // Sorting Array With Bubble Sort

                BubbleSort(array);

            }
            else if(algo.ToLower() == "quick")
            {
                Console.WriteLine("Using Quick Sort");
                // Sorting Array With Quick Sort
                QuickSort(array, 0, array.Length - 1);
            }
            else
            {
                throw new ArgumentException("Invalid sorting Algorithm");
            }
        }


        private void BubbleSort(int[] array)
        {
            Console.WriteLine("Using Bubble Sort");
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        private void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(array, low, high);
                QuickSort(array, low, pivot - 1);
                QuickSort(array, pivot + 1, high);
            }
        }

        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            int swapTemp = array[i + 1];
            array[i + 1] = array[high];
            array[high] = swapTemp;

            return i + 1;
        }

    }
}
