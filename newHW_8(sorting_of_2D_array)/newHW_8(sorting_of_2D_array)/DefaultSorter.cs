using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newHW_8_sorting_of_2D_array_
{
    class DefaultSorter : BaseSorter, ISorter
    {                  
        public int[] Sort(int[] array, bool isSortingFromMinToMax)
        {            
            if (isSortingFromMinToMax)
            {
                Array.Sort(array);
            }
            //inverse logic
            else
                Array.Reverse(array);

            return array;
        }

        public override string ToString()
        {
            return "DefaultSorter";
        }
    }
}
