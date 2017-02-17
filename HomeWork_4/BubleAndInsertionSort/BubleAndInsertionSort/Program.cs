using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubleAndInsertionSort
{
    class Program
    {
        static Random rand = new Random();
        static bool isArraySorted;

        static void Main(string[] args)
        {
            //Buble sorting:           
            int[] array = InitArray();            
            PrintArray(array);
            array = BubleSort(array);
            Console.WriteLine("Buble sorting: >>> \n");
            PrintArray(array);

            //Insertion sort:
            Console.WriteLine("\n\n");
            array = InitArray();
            PrintArray(array);
            array = InsertionSort(array);
            Console.WriteLine("Insertion sorting: >>> \n");
            PrintArray(array);
            Console.ReadKey();
        }

        static int[] InitArray()
        {
            Console.WriteLine("Init Array: >>>\n");
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
            }                   
            return array;
        }

        static int[] SwapNumbersInArray (int[] array, int indexA, int indexB){
            int temp = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = temp;

            return array;
        }
        
        static int[] BubleSort(int[] array)
        {

            for (int i = array.Length; i >= 0; i--)
            {                
                for (int j = 0; j < i - 1; j++)
                    if ((array[j] > array[j + 1]) && !isArraySorted)
                    {
                        array = SwapNumbersInArray(array, j, j + 1);
                        isArraySorted = false;
                    }
                    else
                    {
                        isArraySorted = true;
                    }

                if (isArraySorted)
                {
                    break;
                }
            }

             return array;
        }
        
        static int[] InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i; j >= 0; j--)
                {                    
                    if (array[j + 1] < array[j])
                    {
                        SwapNumbersInArray(array, j, j + 1);
                    }
                }
            }
            return array;
        }

        static void PrintArray(int[] array){
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[{0}]: {1}",i+1, array[i]);
            }
            Console.WriteLine();
        }
    }
}
