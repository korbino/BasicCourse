using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static int top;
        
        static Random rand = new Random();

        static void Main(string[] args)
        {             
             Menu(InitStack());

        }

        //TODO:
        static void Menu(int[] stack)
        {            
            while (true)
            {                
                Console.WriteLine(
                    "=================================\n"+
                    "| (1) - to generate new Stack; |\n" +
                    "| (2) - to Pop;                |\n" +
                    "| (3) - to Push;               |\n" +
                    "| (4) - to IsEmpty;            |\n" +
                    "| (5) - to IsFull;             |\n" +
                    "| (6) - to Peek;               |\n" +
                    "| (7) - to Print stack;        |\n" +
                    "================================="
                    );

                String UserSelection = Console.ReadLine();
                switch (UserSelection)
                {
                    case "1":                        
                        stack = InitStack();
                        break;
                    case "2":
                        Pop(stack);
                        break;
                    case "3":
                        Push(stack);
                        break;
                    case "4":
                        IsEmpty(stack);
                        break;
                    case "5":
                        IsFull(stack);
                        break;
                    case "6":
                        Peek(stack);
                        break;
                    case "7":
                        PrintStack(stack);
                        break;
                    default:
                        Console.WriteLine("INVALID selection! Try again.\n\n");
                        break;
                }
 
            }

        }

        static void Pop(int[] stack)
        {
            if (top > 0)
            {
                Console.WriteLine("Pop for stack[{0}]: {1}\n\n", top, stack[top-1]);
                top--;
            }
            else
            {
                Console.WriteLine("Sorry - stack is empty.\n\n");

            }
            PrintStack(stack);
        }

        static void Push(int[] stack)
        {
            if (top < stack.Length)
            {
                stack[top] = rand.Next(-100, 100);
                Console.WriteLine("Push was performed for stack[{0}]: {1}\n\n", top+1, stack[top]);
                top++;
            }
            else
            {
                Console.WriteLine("Sorry - stack is full\n\n");
            }
            PrintStack(stack);
        }

        static void IsEmpty(int[] stack)
        {
            if (top <= 0)
            {
                Console.WriteLine("Stack is empty: true\n\n");
            }
            else
            {
                Console.WriteLine("Stack is empty: false\n\n");
            }

        }

        static void IsFull(int[] stack)
        {
            if (top >= stack.Length)
            {
                Console.WriteLine("Stack is full: true\n");
            }
            else
            {
                Console.WriteLine("Stack is full: false\n");
            }

        }

        static void Peek(int[] stack)
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

        static int[] InitStack()
        {            
            Console.WriteLine("Init Array: >>>\n");
            int[] stack = new int[10];
            for (int i = 0; i < stack.Length; i++)
            {
                stack[i] = rand.Next(-100, 100);
            }
            top = stack.Length;
            PrintStack(stack);
            return stack;
        }        

        static void PrintStack(int[] stack)
        {
            Console.WriteLine("The current stack state:");
            int j = top;
            while (j > 0){
                Console.WriteLine("stack[{0}]: {1}", j, stack[j-1]);
                j--;
            }
            Console.WriteLine("\n");
        }       
    }
}
