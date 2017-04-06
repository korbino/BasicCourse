using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Sorting
{
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
            sortMenu.ShowMenu();            
        }

     
    }
}
