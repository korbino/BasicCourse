using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7
{
   public interface ISorter<T>  : IPrintable
    {
       /// <summary>
       /// Method, where should be implemented sorting logic
       /// </summary>
        void Sort();
    }
}
