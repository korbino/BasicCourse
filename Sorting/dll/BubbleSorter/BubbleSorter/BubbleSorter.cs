using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{         
   public class BubbleSorter : BaseSorter, ISorter
    {                
        private bool isArraySorted;      

        public int[] Sort(int[] array, bool isSortingFromMinToMax)
        {            

            for (int i = array.Length; i >= 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                  if ((array[j] > array[j + 1]) && isSortingFromMinToMax)
                    {
                        array = Swap(array, j, j + 1);
                        isArraySorted = false;
                    }
                //inverse sorting from max to min.
                else if ((array[j] < array[j + 1]) && !isSortingFromMinToMax)
                    {
                        array = Swap(array, j, j + 1);
                        isArraySorted = false;
                    }
                if (isArraySorted)
                {
                    break;
                }
                isArraySorted = true;
            }

            Console.WriteLine("DEBUG: array was sorted with Bubble Sorter");
            return array;
        }
        public override string ToString()
        {
            return "BubbleSorter";
        }
    }
}
