using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
    class Stack:Buffer
    {
        private int top;
        private int[] stack;
        static Random rand = new Random();
        
        public Stack(int[] array)
        {
            stack = array;
        }

        public void Pop()
        {
            if (top > 0)
            {
                Console.WriteLine("Pop for stack[{0}]: {1}\n\n", top, stack[top - 1]);
                top--;
            }
            else
            {
                Console.WriteLine("Sorry - stack is empty.\n\n");

            }
            Print();
        }

        public void Push()
        {
            if (top < stack.Length)
            {
                Console.Write("\nEnter valid int number: ");
                stack[top] = ValidateInputNumberForIntValue(Console.ReadLine());
                Console.WriteLine("Push was performed for stack[{0}]: {1}\n\n", top + 1, stack[top]);
                top++;
            }
            else
            {
                Console.WriteLine("Sorry - stack is full\n\n");
            }
            Print();
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

        public void Peek()
        {
            if (top > 0)
            {
                Console.WriteLine("The peek value is - stack[{0}]: {1}\n\n", top, stack[top - 1]);
            }
            else
            {
                Console.WriteLine("Looks like the peek is looking \nfor the first element of the stack, \nand it is empty. \n\n");
            }            
        }

        public void Print()
        {
            Console.WriteLine("The current stack state:");
            int j = top;
            while (j > 0)
            {
                Console.WriteLine("stack[{0}]: {1}", j, stack[j - 1]);
                j--;
            }
            Console.WriteLine("\n");
        }   
    }
}
