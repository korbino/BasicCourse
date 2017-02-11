using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3__array_with_min_max_
{
    class Program
    {        
        static int[] array;
        static int min, max;

        static void Main(string[] args)
        {
            InitArray();
            FindMaxValueInArray();
            FindMinValueInArray();

            Console.ReadKey();
        }



        static void InitArray()
        {
            Console.WriteLine("Enter valid size of Array and press Enter:");
            array = new int[ValidateInputNumberForUnsignedIntValue(Console.ReadLine())];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter [{0}] value of array:", i + 1);
                array[i] = ValidateInputNumberForIntValue(Console.ReadLine());
            }
            Console.WriteLine("Congradulate, your array was successfully init with {0} size.", array.Length);
        }

        static void FindMaxValueInArray()
        {   //search for max:
            max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("The max value in array is: " + max);
        }        
        
        static void FindMinValueInArray()
        {   //search for min:
            min = array[0];
            for(int i = 0; i < array.Length; i ++){
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("The min value in array is: " + min);
        }



        static bool IsItInteger(String value)
        {
            int number;
            if (int.TryParse(value, out number))
            {
                return true;
            }
            else {
                return false;
            }
        }

        static int ValidateInputNumberForIntValue(String value)
        {
            int result;
            while (true)
            {
                if (IsItInteger(value))
                {
                    result = Convert.ToInt32(value);
                    break;
                }
                else
                {
                    Console.WriteLine("You entered not valid value, please reentere it again:");
                    value = Console.ReadLine();
                }
            }
            return result;
        }

        static int ValidateInputNumberForUnsignedIntValue(String value)
        {
            int result;
            while (true)
            {
                if ((IsItInteger(value)) && ((Convert.ToInt32(value) > 0)))
                {
                    result = Convert.ToInt32(value);
                    break;
                }
                else
                {
                    Console.WriteLine("You entered not valid value for array size, please reentere it again:");
                    value = Console.ReadLine();
                }
            }
            return result;
        }
    }
}
