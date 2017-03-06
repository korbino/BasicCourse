using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7
{
   abstract class Buffer <T> : IBuffer<T>
    {

        /// <summary>
        /// This method will check if [array] is Empty
        /// Will be overriden for each class: Stack\Queue
        /// </summary>
        /// <returns>boolean</returns>
        public virtual bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method will check if [array] is Full
        /// Will be overriden for each class: Stack\Queue
        /// </summary>
        /// <returns>boolean</returns>
        public virtual bool IsFull()
        {
            throw new NotImplementedException();
        }

       /// <summary>
       /// Dsiplaying avaliable value, should be overrided
       /// </summary>
       /// <returns>object</returns>
        abstract public T Peek();

       /// <summary>
       /// Printing to console, should be overrided
       /// </summary>
        abstract public void Print(); 
       
    }
}
