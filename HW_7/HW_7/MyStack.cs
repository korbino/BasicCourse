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

        public MyStack(T[] array)
        {
            stack = array;
        }

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

        public int Pop()
        {           
            if (top > 0)
            {                
                Console.Write("Pop for stack[{0}]: ", top);
                int tmpTop = top;
                top--;                
                int debugResult = Convert.ToInt32(Convert.ToString(stack[tmpTop - 1]));
                return debugResult;
            }
            else
            { 
                throw new IndexOutOfRangeException();
            }            
        }

        public override int Peek()
        {
            if (top > 0)
            {
                
                Console.WriteLine("The peek value is - stack[{0}]: ", top);
                return Convert.ToInt32(Convert.ToString(stack[top - 1]));   
            }
            else
            {
                throw new IndexOutOfRangeException();
            }            
        }

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
