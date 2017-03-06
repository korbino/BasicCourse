using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7
{
    public interface IMyStack<T>
    {
        /// <summary>
        /// Write new object to stack
        /// </summary>
        /// <param name="IncomingObject">object</param>
        void Push(T IncomingObject);

        /// <summary>
        /// Extructing object from stack
        /// </summary>
        /// <returns>object</returns>
        T Pop();
    }
}
