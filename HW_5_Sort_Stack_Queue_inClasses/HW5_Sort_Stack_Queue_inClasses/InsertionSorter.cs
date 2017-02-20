using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_Sort_Stack_Queue_inClasses
{
    class InsertionSorter
    {
        private int[] array;

        public InsertionSorter(int[] array)
        {
            this.array = array;
        }

        public void Sort()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if (array[j + 1] < array[j])
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }
        }

        private int[] Swap(int[] array, int indexA, int indexB)
        {
            int temp = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = temp;

            return array;
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
