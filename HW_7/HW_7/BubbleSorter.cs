using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7
{
    class BubbleSorter<T> : Sorter<T> where T:IComparable
    {
        private bool isArraySorted;
        T[] array;

        public BubbleSorter(T[] array)
        {
            this.array = array;
        }
       

        public override void Sort()
        {
            for (int i = array.Length; i >= 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                    //if ((array[j] > array[j + 1]))
                    if (array[j].CompareTo(array[j+1]) == 1)
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

        public override void Print(String message)
        {
            Console.WriteLine(message);
            PrintArray(array);
            Console.WriteLine();
        }
    }
}
