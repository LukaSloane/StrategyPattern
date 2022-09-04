using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.SortStrategy
{
    internal class SlowBubbleSortStrategy : ISortStrategy
    {
        public void Sort(int[] input)
        {
            Console.WriteLine("Output is:");
            
            int temp;

            for (int i = 0; i < input.Length; i++) {
                
                for (int j = 0; j < input.Length - 1; j++) {
                    
                    if (input[j] > input[j + 1]) {
                        temp = input[j + 1];
                        input[j + 1] = input[j];
                        input[j] = temp;
                    }
                }
            }

            foreach (int i in input)
            {
                Console.WriteLine($"{i},");
            }
        }
    }
}
