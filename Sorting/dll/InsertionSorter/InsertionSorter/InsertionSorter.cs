using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
   public class InsertionSorter : BaseSorter, ISorter
    {
        //event:
        public event SortedEventHandler ArrayWasSorted;

        public int[] Sort(int[] array, bool isSortingFromMinToMax)
        {
            stopWatchLocal.Start();
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if ((array[j + 1] < array[j]) && isSortingFromMinToMax)
                    {
                        Swap(array, j, j + 1);
                    }
                    //inverse logic                        
                    else if ((array[j + 1] > array[j] && !isSortingFromMinToMax))
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }

            stopWatchLocal.Stop();
            //raise the event:
            OnArrayWasSorted(array, stopWatchLocal, this.ToString());

            //Console.WriteLine("DEBUG: array was sorted with Insertion Sorter");
            return array;
        }

        public override string ToString()
        {
            return "InsertionSorter";
        }

        //describe method for rase the event:
        protected virtual void OnArrayWasSorted(int[] array, Stopwatch stopWatchLocal, String sorterName)
        {
            if (ArrayWasSorted != null)
            {
                ArrayWasSorted(new ArrayWasSortedEventArgs() { Array1D = array, stopWatch = stopWatchLocal, SorterName = sorterName });
            }
        }
    }
}
