using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.SortStrategy;

namespace StrategyPattern
{
    internal class Sorter
    {
        private ISortStrategy sortStrategy;

        public void Sort(int[] input, Speed speed)
        {
            if (speed == Speed.Slow)
            {
                sortStrategy = new SlowBubbleSortStrategy();
            }
            else if(speed == Speed.Medium)
            {
                sortStrategy = new MediumInsertionSortStrategy();
            }
            else if(speed == Speed.Fast)
            {
                sortStrategy = new FastQuickSortStrategy();
            }

            sortStrategy.Sort(input);
        }
    }
}
