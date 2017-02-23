using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
    class Sorter
    {
        
        protected int[] Swap(int[] array, int indexA, int indexB)
        {
            int temp = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = temp;

            return array;
        }      

        protected void Print(int[] array)
        {            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[{0}]: {1}", i + 1, array[i]);
            }
            Console.WriteLine();
        }

        virtual public void Sort()
        {
            //this method will be overridden
        }

    }
}
