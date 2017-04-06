using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
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
                    array[i, j] = rand.Next(0, 1000);
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
                    try
                    {
                        tmpArray[i, j] = array[counterOfValueIn1DArray];
                        counterOfValueIn1DArray++;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    
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

        /// <summary>
        /// This method goiong to loop, untill you'll enter valid int value
        /// </summary>
        /// <param name="value">read value from console</param>
        /// <param name="min">minimal limit number</param>
        /// <param name="max">maximal limit number</param>
        /// <returns>validated int value</returns>
        public static int ValidateInputNumberForIntValue(String value, int min, int max)
        {
            int result;
            while (true)
            {
                if (IsItInteger(value))
                {
                    result = Convert.ToInt32(value);
                    //if (result >= min && result <= max)
                    if (Enumerable.Range(min, max).Contains(result))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You entered not valid value, please reentere it again:");
                        value = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("You entered not valid value, please reentere it again:");
                    value = Console.ReadLine();
                }
            }
            return result;
        }

        /// <summary>
        /// Parsing string for int.
        /// </summary>
        /// <param name="value">String</param>
        /// <returns>In case of string contain only int number - return true and vise versa</returns>
        public static bool IsItInteger(String value)
        {
            int number;
            if (int.TryParse(value, out number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
