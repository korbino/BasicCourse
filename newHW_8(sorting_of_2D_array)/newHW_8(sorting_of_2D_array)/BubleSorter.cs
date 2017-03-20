using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newHW_8_sorting_of_2D_array_
{
    //TODO: overide toString for to recieve name of sorter
    //TODO: define private vars
    class BubleSorter : BaseSorter, ISorter
    {        
        int[] array;
        bool isArraySorted;      

        public int[,] Sort(int[,] array2D, bool isSortingFromMinToMax)
        {
            this.array = Convert2DArrayTo1D(array2D);

            for (int i = array.Length; i >= 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                  if ((array[j] > array[j + 1]) && isSortingFromMinToMax)
                    {
                        array = Swap(array, j, j + 1);
                        isArraySorted = false;
                    }
                //inverse sorting
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

            return Convert1DArraTo2D(array, array2D.GetLength(0), array2D.GetLength(1));
        }       
    }
}
