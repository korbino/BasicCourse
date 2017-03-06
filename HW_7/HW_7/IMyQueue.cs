using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7
{
    public interface IMyQueue<T>
    {
        void Enqueue(T incomingObject);                
        T Dequeue();
    }
}
