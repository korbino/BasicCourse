using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{      
   public class BubbleSorter : BaseSorter, ISorter
    {                
       private bool isArraySorted;
       
       //event:
       public event SortedEventHandler ArrayWasSorted;

        public int[] Sort(int[] array, bool isSortingFromMinToMax)
        {
            stopWatchLocal.Start();

            for (int i = array.Length; i >= 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                  if ((array[j] > array[j + 1]) && isSortingFromMinToMax)
                    {
                        array = Swap(array, j, j + 1);
                        isArraySorted = false;
                    }
                //inverse sorting from max to min.
                else if ((array[j] < array[j + 1]) && !isSortingFromMinToMax)
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

            stopWatchLocal.Stop();
            //raise the event:
            OnArrayWasSorted(array, stopWatchLocal, this.ToString());

           // Console.WriteLine("DEBUG: array was sorted with Bubble Sorter");
            return array;
        }

        public override string ToString()
        {
            return "BubbleSorter";
        }

        //describe method for rase the event:
        protected virtual void OnArrayWasSorted(int[] array, Stopwatch stopWatchLocal, String sorterName)
        {
            if (ArrayWasSorted != null)
            {
                ArrayWasSorted(new ArrayWasSortedEventArgs(){Array1D = array, stopWatch = stopWatchLocal, SorterName = sorterName});
            }
        }
    }
}
