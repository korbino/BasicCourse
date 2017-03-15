using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newHW_8_sorting_of_2D_array_
{
    class SelectionSorter : SorterCommon, ISorter
    {
        int[] array;
        public int[,] Sort(int[,] array2D, bool isSortingFromMinToMax)
        {
            array = Convert2DArrayTo1D(array2D);
            for (int i = 0; i < array.Length - 1; i++)
            {                
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if ((array[j] < array[min]) && isSortingFromMinToMax)
                    {
                        min = j;
                    }
                    else if ((array[j] > array[min]) && !isSortingFromMinToMax)
                    {
                        min = j;
                    }
                }
                int dummy = array[i];
                array[i] = array[min];
                array[min] = dummy;
            }
            return Convert1DArraTo2D(array, array2D.GetLength(0), array2D.GetLength(1));
        }
    }
}
