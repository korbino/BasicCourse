using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newHW_8_sorting_of_2D_array_
{
    public static class SortUtil
    {
        private static Random rand = new Random();
        
        //generate and return new 2D array
        public static int[,] Generate2DArray(int dim_1, int dim_2)
        {
            int[,] array = new int[dim_1, dim_2];
            for (int i = 0; i < dim_1; i++)
            {
                for (int j = 0; j < dim_2; j++)
                {
                    array[i, j] = rand.Next(0, 100);
                }
            }

            return array;
        }

        ///converting 2d array to 1d
        public static int[] Convert2DArrayTo1D(int[,] array2d)
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
        public static int[,] Convert1DArraTo2D(int[] array, int arrayDim_1, int arrayDim_2)
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

        //print 2d array to console:
        public static void Print2DArrayToConsole(int[,] array2D)
        {
            for (int i = 0; i < array2D.GetLength(0); i++)//rows
            {
                for (int j = 0; j < array2D.GetLength(1); j++)//columns
                {
                    if (array2D[i, j] < 10)
                    {
                        Console.Write(string.Format("0{0} ", array2D[i, j]));
                    }
                    else
                    {
                        Console.Write(string.Format("{0} ", array2D[i, j]));
                    }                    
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
    }
}
