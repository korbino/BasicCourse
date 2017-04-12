using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class ArrayWasSortedEventArgs : EventArgs
    {
        //public bool IsArraWasSorted { get; set; }
        //public object Array1D { get; set; }
        public int[] Array1D { get; set; }
        public String SorterName { get; set; }
        public Stopwatch stopWatch = new Stopwatch();

    }
}
