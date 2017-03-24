using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newHW_8_sorting_of_2D_array_
{     
    class BubleSorter : BaseSorter, ISorter
    {                
        private bool isArraySorted;      

        public int[] Sort(int[] array, bool isSortingFromMinToMax)
        {            

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

            return array;
        }
        public override string ToString()
        {
            return "BubleSorter";
        }
    }
}
