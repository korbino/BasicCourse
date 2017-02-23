using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
    class InsertionSorter: Sorter
    {
        private int[] array;

        public InsertionSorter(int[] array)
        {
            this.array = array;
        }

        override public void Sort()
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

        public void PrintArray(String message)
        {
            Console.WriteLine(message);
            Print(array);
            Console.WriteLine();
        }      
    }
}
