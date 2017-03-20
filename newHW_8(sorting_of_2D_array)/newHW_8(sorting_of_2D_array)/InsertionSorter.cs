using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newHW_8_sorting_of_2D_array_
{
    class InsertionSorter : BaseSorter, ISorter
    {
        int[] array;

        public int[,] Sort(int[,] array2D, bool isSortingFromMinToMax)
        {
            this.array = Convert2DArrayTo1D(array2D);

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if ((array[j + 1] < array[j]) && isSortingFromMinToMax)
                    {
                        Swap(array, j, j + 1);
                    }
                    else if ((array[j + 1] > array[j] && !isSortingFromMinToMax))
                    {
                        Swap(array, j, j + 1);                       
                    }
                }
            }
            return Convert1DArraTo2D(array, array2D.GetLength(0), array2D.GetLength(1));
        }
    }
}
