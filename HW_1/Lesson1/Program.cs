using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            if (numberOne % numberTwo == 0)
            {
                Console.WriteLine("The second number is divider of first");
            }
            else
            {
                Console.WriteLine("The second number is NOT divider of first");
            }

            Console.ReadLine();
        }
    }
}
