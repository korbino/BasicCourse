using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sorting
{    //TODO: Adding dynamic load of DLLs, using: "c# reflection dynamic dll loading"
    class Program
    {             
        static void Main(string[] args)
        {
            List<ISorter> sorterList = new List<ISorter> {
                new BubbleSorter(),
                new InsertionSorter(),
                new DefaultSorter(),
                new SelectionSorter()            
            };            
            SortMenu sortMenu = new SortMenu(sorterList);
            
            //linking event from sorters(publisher) with SortMenu (subscriber)
            foreach (ISorter sorter in sorterList)
            {
                sorter.ArrayWasSorted += sortMenu.OnArrayWasSorted;
            }

            sortMenu.ShowMenu();            
        }     
    }
}

//TODO: validator move to separate class and dll
//TODO: thread.IsBackground = true;
//TODO: make all sorters with events



//TO READ:
// - лямбда выражения
// - thread: разница между джойн и стопом,
// - ивенты внутри потока
// - разница между thread & task