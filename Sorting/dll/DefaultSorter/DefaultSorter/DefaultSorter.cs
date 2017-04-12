using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class DefaultSorter : BaseSorter, ISorter
    {
        //event:
        public event SortedEventHandler ArrayWasSorted;


        public int[] Sort(int[] array, bool isSortingFromMinToMax)
        {
            stopWatchLocal.Start();
            if (isSortingFromMinToMax)
            {
                Array.Sort(array);
            }
            //inverse logic
            else
                Array.Reverse(array);
            //Console.WriteLine("DEBUG: array was sorted with Default Sorter");

            stopWatchLocal.Stop();
            //raise the event:
            OnArrayWasSorted(array, stopWatchLocal, this.ToString());

            return array;
        }

        public override string ToString()
        {
            return "DefaultSorter";
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
