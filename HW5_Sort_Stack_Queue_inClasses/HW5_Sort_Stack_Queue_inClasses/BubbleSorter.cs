using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_Sort_Stack_Queue_inClasses
{
    class BubbleSorter
    {
        private bool isArraySorted;
        private int[] array;

        public BubbleSorter(int[] array)
        {
            this.array = array;                       
        }      

        private int[] Swap(int[] array, int indexA, int indexB)
        {
            int temp = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = temp;

            return array;
        }

        public void Sort()
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
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[{0}]: {1}", i + 1, array[i]);
            }
            Console.WriteLine();
        }
    }
}
