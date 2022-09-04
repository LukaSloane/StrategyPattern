using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.SortStrategy
{
    internal interface ISortStrategy
    {
        public void Sort(int[] input);
    }
}
