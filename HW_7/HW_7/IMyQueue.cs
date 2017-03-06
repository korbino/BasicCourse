using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7
{
    public interface IMyQueue<T>
    {
        /// <summary>
        /// Writing object in to container
        /// </summary>
        /// <param name="incomingObject">object</param>
        void Enqueue(T incomingObject); 
 
        /// <summary>
        /// Extructing avaliable object
        /// </summary>
        /// <returns>object</returns>     
        T Dequeue();
    }
}
