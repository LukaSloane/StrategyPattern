using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.SortStrategy
{
    internal class FastQuickSortStrategy : ISortStrategy
    {
        public void Sort(int[] input)
        {
            Console.WriteLine("Output is:");

            QuickSort(input, 0, input.Length - 1);

            foreach (int i in input)
            {
                Console.WriteLine($"{i},");
            }
        }

        private void QuickSort(int[] input, int leftIndex, int rightIndex)
        {
            int i = leftIndex;
            int j = rightIndex;
            int pivot = input[leftIndex];
            while (i <= j)
            {
                while (input[i] < pivot)
                {
                    i++;
                }

                while (input[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = input[i];
                    input[i] = input[j];
                    input[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
            {
                QuickSort(input, leftIndex, j);
            }
            if (i < rightIndex)
            {
                QuickSort(input, i, rightIndex);
            }
        }
    }
}
