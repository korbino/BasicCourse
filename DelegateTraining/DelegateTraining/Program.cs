using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTraining
{
    class Program
    {
        delegate void MyDel(int x);
        static void Main(string[] args)
        {
            MyDel md = new MyDel(Start);
            md += Stop;

            md(10);

            Console.ReadLine();
        }

        static void Start(int x)
        {
            //x = 10;
            Console.WriteLine("Start: " + x);
        }

        static void Stop(int x)
        {
            //x = 0;
            Console.WriteLine("Stop: " + x);
        }
    }
}
