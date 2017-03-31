using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BaseSorter
    {
        //swapping between 2 numbers in array
        protected int[] Swap(int[] array, int indexA, int indexB)
        {
            int temp = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = temp;            
            return array;
        }              
    }
}
