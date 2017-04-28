using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class DLLImporterFromFolder
    {        
        /// <summary>
        /// Creating the list of ISorter objectsm with sorters DLLs from specific path, which implementing the ISorter interface
        /// </summary>
        /// <param name="path">The path, where all DLLs located</param>
        /// <returns>Returning the list of Sorters as ISorter</returns>
        public List<ISorter> GetListOfSortersFromPath(String path)
        {
            List<ISorter> listOfSorters = new List<ISorter>();

            //Go thrue the list of assembled files:
            foreach (var DLL in GetTheListOfAssembledDLLsByPath(path))
            {
                try
                {
                    //Go thrue the all types of loaded DLLs:
                    foreach (Type type in DLL.GetTypes())
                    {
                        //check if dll implemeting the inteface "ISorter":
                        if (typeof(ISorter).IsAssignableFrom(type))
                        {
                           // Console.WriteLine("DEBUG:{0} Dll is implementing ITest interface", type.ToString());                        
                            listOfSorters.Add((Activator.CreateInstance(type)) as ISorter);
                        }
                    }
                }
                catch (ReflectionTypeLoadException e)
                {
                    //here could be explanation if needed.
                }
                
            }
                        
            return listOfSorters;
        }


        /// <summary>
        /// Go thrue the list of files and creating list of Assembly files
        /// </summary>
        /// <param name="path">folder location</param>
        /// <returns>Returing the list of loaded files (Assembled)</returns>
        private List<System.Reflection.Assembly> GetTheListOfAssembledDLLsByPath(string path)
        {
            List<System.Reflection.Assembly> listOfAssemblyDlls = new List<System.Reflection.Assembly>();
            
            foreach (String filePath in GetTheListOfReadedFilesByPath(path))
            {
                try
                {
                    listOfAssemblyDlls.Add(Assembly.LoadFile(filePath));
                }
                catch (BadImageFormatException e)
                {
                    //Here could be describe the explenation for it...                    
                }                
            }

            return listOfAssemblyDlls;
        }

        /// <summary>
        /// Reading files from dirrectory
        /// </summary>
        /// <param name="path">target folder path</param>
        /// <returns>Returning the list of strings with full address all existed files</returns>
        private List<string> GetTheListOfReadedFilesByPath(string path)
        {
            List<string> listOfFiles = new List<string>();
            //read directory :
            foreach (string file in Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories))
            {
                listOfFiles.Add(file);
                //Console.WriteLine(file);
            }

            return listOfFiles;
        }

        
    }
}
