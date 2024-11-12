using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingSystem.Strategy.After
{
    public class Sorter
    {
        private readonly ISortStrategy _sortStrategy;

        public Sorter(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Sort(int[] array)
        {
            _sortStrategy.Sort(array);
        }



      

    }
}
