using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingSystem.Strategy.After
{
    public class QuickSort : ISortStrategy
    {
        public void Sort(int[] array)
        {
            QuickSortAlgo(array, 0, array.Length - 1);
        }

        private void QuickSortAlgo(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(array, low, high);
                QuickSortAlgo(array, low, pivot - 1);
                QuickSortAlgo(array, pivot + 1, high);
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
