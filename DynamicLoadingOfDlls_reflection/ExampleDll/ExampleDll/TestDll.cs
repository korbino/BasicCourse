using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace ExampleDll
{
    public class TestDll : ITest
    {
        public void DoSomething(){
            Console.WriteLine("Doing something.... from: " + this);
        }
    }
}
