using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7
{
    class InsertionSorter<T> : Sorter<T> where T : IComparable
    {
        T[] array;

        public InsertionSorter(T[] array)
        {
            this.array = array;
        }

        public override void Sort()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    //if (array[j + 1] < array[j])
                    if(array[j+1].CompareTo(array[j]) == -1)
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }
        }

        public override void Print()
        {
            PrintArray(array);
            Console.WriteLine();
        }
    }
}
