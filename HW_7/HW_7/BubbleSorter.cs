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

        /// <summary>
        /// This class simulating Buble sorting process
        /// </summary>
        /// <param name="array">Recieving Array of objects</param>
        public BubbleSorter(T[] array)
        {
            this.array = array;
        }
       
        /// <summary>
        /// This method is doing sorting of array of objects
        /// </summary>
        public override void Sort()
        {
            for (int i = array.Length; i >= 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
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

        /// <summary>
        /// This method is printing the array
        /// </summary>
        public override void Print()
        {
            PrintArray(array);
            Console.WriteLine();
        }
    }
}
