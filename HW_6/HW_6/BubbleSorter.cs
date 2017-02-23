using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
    class BubbleSorter : Sorter
    {
        private bool isArraySorted;
        private int[] array;

        public BubbleSorter(int[] array)
        {
            this.array = array;
        }        

       override public void Sort()
        {

            for (int i = array.Length; i >= 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                    if ((array[j] > array[j + 1]))
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
        }

        public void PrintArray(String message)
        {
            Console.WriteLine(message);
            Print(array);
            Console.WriteLine();
        }
    }
}
