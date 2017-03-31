using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class DefaultSorter : BaseSorter, ISorter
    {
        public int[] Sort(int[] array, bool isSortingFromMinToMax)
        {
            if (isSortingFromMinToMax)
            {
                Array.Sort(array);
            }
            //inverse logic
            else
                Array.Reverse(array);
            Console.WriteLine("DEBUG: array was sorted with Default Sorter");
            return array;
        }

        public override string ToString()
        {
            return "DefaultSorter";
        }
    }
}
