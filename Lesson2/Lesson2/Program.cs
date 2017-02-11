using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 100; i++)
            //{
            //    if ((i % 3 == 0) && (i % 5 == 0))
            //    {                    
            //        Console.WriteLine("FizzBuzz");
            //        continue; 
            //    }else if (i % 3 == 0) {
            //        Console.WriteLine("Fizz");
            //        continue; 
            //    }else if (i % 5 == 0) {
            //        Console.WriteLine("Buzz");
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }                
            //}
            //Console.ReadLine();
            Function_1();
        }

        static void Function_1()
        {
            int val = 1;
            Function_2(ref val);
            Console.WriteLine("VAL:{0}", val);
            Console.ReadLine();
        }
        static void Function_2(ref int value)
        {
            value = 20;
        }
    }
}
