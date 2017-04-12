using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
   //delegate:  
   public delegate void SortedEventHandler(ArrayWasSortedEventArgs args);   
   
    public interface ISorter
    {           
        int[] Sort(int[] array, bool isSortingFromMinToMax);
        event SortedEventHandler ArrayWasSorted;
    }
}
