using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7
{
    class MyStack<T> : Buffer<T>, IMyStack<T>
    {
        int top;
        T[] stack;
        Random rand = new Random();
        
        /// <summary>
        /// Implementing the Stack
        /// </summary>
        /// <param name="array">Recieve array of objects</param>
        public MyStack(T[] array)
        {
            stack = array;
        }

        /// <summary>
        /// Insert to stack new object, in case there is avaliable place
        /// </summary>
        /// <param name="IncomingObject">Object </param>
        public void Push(T IncomingObject)
        {
            if (top < stack.Length)
            {                
                stack[top] = IncomingObject;
                Console.WriteLine("Push was performed for myStack[{0}]: {1}\n\n", top + 1, stack[top]);
                top++;
            }
            else
            {
                Console.WriteLine("Sorry - myStack is full\n\n");
            }
            Print();
        }

        /// <summary>
        /// Extract last avalibale value
        /// </summary>
        /// <returns>Object T</returns>
        public T Pop()
        {           
            if (top > 0)
            {                
                Console.Write("Pop for stack[{0}]: ", top);
                int tmpTop = top;
                top--;                                
                return stack[tmpTop - 1];
            }
            else
            { 
                throw new IndexOutOfRangeException();
            }            
        }

        /// <summary>
        /// Display last avaliable value 
        /// </summary>
        /// <returns>Object</returns>
        public override T Peek()
        {
            if (top > 0)
            {
                
                Console.WriteLine("The peek value is - stack[{0}]: ", top);
                return stack[top - 1];   
            }
            else
            {
                throw new IndexOutOfRangeException();
            }            
        }

        /// <summary>
        /// Check if Stack is empty
        /// </summary>
        /// <returns>Boolean</returns>
        override public bool IsEmpty()
        {
            if (top <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Check if stack is Full
        /// </summary>
        /// <returns>Boolean</returns>
        override public bool IsFull()
        {
            if (top >= stack.Length)
            {
                return true;
            }
            else
            {
                return false;
            }

        }        
        
        /// <summary>
        /// Print stack to console
        /// </summary>
        public override void Print()
        {
            Console.WriteLine("The current myStack state:");
            int j = top;
            while (j > 0)
            {
                Console.WriteLine("myStack[{0}]: {1}", j, stack[j - 1]);
                j--;
            }
            Console.WriteLine("\n");
        }
    }
}
