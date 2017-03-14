using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newHW_8_sorting_of_2D_array_
{
    class SorterCommon
    {
        //swapping between 2 numbers in array
        protected int[] Swap(int[] array, int indexA, int indexB)
        {
            int temp = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = temp;

            return array;
        }       

        //converting 2d array to 1d
        protected int[] Convert2DArrayTo1D(int[,] array2d)
        {
            int counter = 0;
            int[] tmpArray = new int[array2d.Length];
            foreach (int value in array2d)
            {
                tmpArray[counter] = value;
                if (counter < array2d.Length)
                {
                    counter++;
                }
            }

            return tmpArray;
        }

        //comverting 1d array to 2d back
        protected int[,] Convert1DArraTo2D(int[] array, int arrayDim_1, int arrayDim_2)
        {
            int[,] tmpArray = new int[arrayDim_1, arrayDim_2];
            int counterOfValueIn1DArray = 0;
            for (int i = 0; i < arrayDim_1; i++)
            {
                for (int j = 0; j < arrayDim_2; j++)
                {
                    tmpArray[i, j] = array[counterOfValueIn1DArray];
                    counterOfValueIn1DArray++;
                }
            }
            return tmpArray;
        }
    }
}
