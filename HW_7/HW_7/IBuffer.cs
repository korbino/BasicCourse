using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7
{
    public interface IBuffer<T> : IPrintable
    {
        bool IsEmpty();
        bool IsFull();
        int Peek();
    }
}
