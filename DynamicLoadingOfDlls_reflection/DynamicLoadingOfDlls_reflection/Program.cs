using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Test;
using System.IO;

namespace DynamicLoadingOfDlls_reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfFiles = new List<string>();
            //read directory :
            foreach (string file in Directory.EnumerateFiles("C:\\dll", "*.*", SearchOption.AllDirectories))
            {
                listOfFiles.Add(file);
                //Console.WriteLine(file);
            }



            var DLL = Assembly.LoadFile(@"C:\dll\ExampleDll.dll");            
            foreach (Type type in DLL.GetTypes())
            {                            
                var c = Activator.CreateInstance(type);            
                type.InvokeMember("DoSomething", BindingFlags.InvokeMethod, null, c, new object[]{});
                //dynamic c = Activator.CreateInstance(type);
                //c.DoSomething();                        


                //check if dll implemeting the inteface "ITest"
                if (typeof(ITest).IsAssignableFrom(type))
                {
                    Console.WriteLine("Dll is implementing ITest interface" + type.ToString());
                }
            }

            Console.ReadLine();
        }

        
    }
}
