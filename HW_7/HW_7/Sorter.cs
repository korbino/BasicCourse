using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7
{
    abstract class Sorter<T> : ISorter<T>
    {
        public abstract void Sort();

        public abstract void Print(String message);

       protected T[] Swap(T[] array, int indexA, int indexB)
       {
           T temp = array[indexA];
           array[indexA] = array[indexB];
           array[indexB] = temp;

           return array;
       }

       protected void PrintArray(T[] array)
       {
           for (int i = 0; i < array.Length; i++)
           {
               Console.WriteLine("array[{0}]: {1}", i + 1, array[i]);
           }
           Console.WriteLine();
       }


    }
}
