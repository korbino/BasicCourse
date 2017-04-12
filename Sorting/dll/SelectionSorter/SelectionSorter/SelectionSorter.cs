using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
   public class SelectionSorter : BaseSorter, ISorter
    {
        //event:
        public event SortedEventHandler ArrayWasSorted;

        public int[] Sort(int[] array, bool isSortingFromMinToMax)
        {
            stopWatchLocal.Start();
            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if ((array[j] < array[min]) && isSortingFromMinToMax)
                    {
                        min = j;
                    }
                    //inverse logic
                    else if ((array[j] > array[min]) && !isSortingFromMinToMax)
                    {
                        min = j;
                    }
                }
                int dummy = array[i];
                array[i] = array[min];
                array[min] = dummy;
            }

            stopWatchLocal.Stop();
            //raise the event:
            OnArrayWasSorted(array, stopWatchLocal, this.ToString());

           // Console.WriteLine("DEBUG: array was sorted with Selection Sorter");
            return array;
        }

        public override string ToString()
        {
            return "SelectionSorter";
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
