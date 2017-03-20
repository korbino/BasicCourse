using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newHW_8_sorting_of_2D_array_
{
    class DefaultSorter : BaseSorter, ISorter
    {
        int[] array;

        //TODO: remove converatation logic from sort methods..
        //e.g. "sorter util"
        public int[,] Sort(int[,] array2D, bool isSortingFromMinToMax)
        {
            array = Convert2DArrayTo1D(array2D);

            if (isSortingFromMinToMax)
            {
                Array.Sort(array);
            }
            else
                Array.Reverse(array);

            return Convert1DArraTo2D(array, array2D.GetLength(0), array2D.GetLength(1));
        }
    }
}
