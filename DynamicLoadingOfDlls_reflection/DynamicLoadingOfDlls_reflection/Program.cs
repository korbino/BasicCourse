using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Test;

namespace DynamicLoadingOfDlls_reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var DLL = Assembly.LoadFile(@"C:\dll\ExampleDll.dll");            
            foreach (Type type in DLL.GetTypes())
            {
                bool isImplementedInterface = typeof(ITest).IsAssignableFrom(type);
                if (isImplementedInterface)
                {
                    Console.WriteLine("Dll is implementing ITest interface");
                }

                var c = Activator.CreateInstance(type);            
                type.InvokeMember("DoSomething", BindingFlags.InvokeMethod, null, c, new object[]{});
                //dynamic c = Activator.CreateInstance(type);
                //c.DoSomething();                        
            }

            Console.ReadLine();
        }
    }
}
