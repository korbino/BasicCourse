using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DynamicLoadingOfDlls_reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var DLL = Assembly.LoadFile(@"C:\dll\ExampleDll.dll");

            foreach (Type type in DLL.GetExportedTypes())
            {
                var c = Activator.CreateInstance(type);
                //c.DoSomething();
                type.InvokeMember("DoSomething", BindingFlags.InvokeMethod, null, c, new object[]{});
                
                
            }

            Console.ReadLine();
        }
    }
}
