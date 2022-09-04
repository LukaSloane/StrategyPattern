using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.SortStrategy
{
    internal class MediumInsertionSortStrategy : ISortStrategy
    {
        public void Sort(int[] input)
        {
            Console.WriteLine("Output is:");
            
            int n = input.Length;
            for (int i = 1; i < n; ++i) {
                
                int key = input[i];
                int j = i - 1;
 
                while (j >= 0 && input[j] > key) {
                    input[j + 1] = input[j];
                    j--;
                }
                input[j + 1] = key;
            }

            foreach (int i in input)
            {
                Console.WriteLine($"{i},");
            }
        }
    }
}
