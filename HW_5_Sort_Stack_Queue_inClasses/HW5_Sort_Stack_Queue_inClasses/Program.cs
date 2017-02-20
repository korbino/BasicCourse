using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_Sort_Stack_Queue_inClasses
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            BubbleSorter bbSorter = new BubbleSorter(InitArray());            
            bbSorter.PrintArray("Array before sorting:");
            bbSorter.Sort();
            bbSorter.PrintArray("Array after BBL sort:");

            InsertionSorter insertionSorter = new InsertionSorter(InitArray());
            insertionSorter.PrintArray("Array before sorting:");
            insertionSorter.Sort();
            insertionSorter.PrintArray("Array after insertion sorter:");

            Console.WriteLine("Wellcome to Stack Menu!");
            Stack stack = new Stack(InitArray());
            StackMenu(stack);

            Console.WriteLine("Wellcome to Queue Menu!");
            Queue queue = new Queue(InitBuffer());
            QueueMenu(queue);


            Console.ReadKey();
        }

        static int[] InitArray()
        {
            Console.WriteLine("Init Array: >>>\n");
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
            }
            return array;
        }

        static int[] InitBuffer()
        {
            int[] buffer = new int[10];
            return buffer;
        }

        static void StackMenu(Stack stack)
        {
            bool isExit = false;

            while (true)
            {
                Console.WriteLine(
                    "=================================\n" +
                    "| (1) - to generate new Stack; |\n" +
                    "| (2) - to Pop;                |\n" +
                    "| (3) - to Push;               |\n" +
                    "| (4) - to IsEmpty;            |\n" +
                    "| (5) - to IsFull;             |\n" +
                    "| (6) - to Peek;               |\n" +
                    "| (7) - to Print stack;        |\n" +
                    "| (8) - to Exit;               |\n" +
                    "================================="
                    );

                String UserSelection = Console.ReadLine();
                switch (UserSelection)
                {
                    case "1":
                        stack = new Stack(InitArray());
                        break;
                    case "2":
                        stack.Pop();
                        break;
                    case "3":
                        stack.Push();
                        break;
                    case "4":
                        if(stack.IsEmpty()){
                            Console.WriteLine("Stack is Empty:\n");
                        }else{
                            Console.WriteLine("Stack is not Empty:\n");
                        }
                        break;
                    case "5":
                        if (stack.IsFull())
                        {
                            Console.WriteLine("Stack is Full.\n");
                        }
                        else
                        {
                            Console.WriteLine("Stack is not Full.\n");
                        }
                        break;
                    case "6":
                        stack.Peek();
                        break;
                    case "7":
                        stack.Print();
                        break;
                    case "8":
                        isExit = true;
                        break;
                    default:
                        Console.WriteLine("INVALID selection! Try again.\n\n");
                        break;
                }

                if (isExit)
                {
                    break;
                }
            }

        }

        static void QueueMenu(Queue queue)
        {
            bool isExit = false;
            while (true)
            {
                Console.WriteLine(
                    "=================================\n" +
                    "| (1) - to init new Buffer;    |\n" +
                    "| (2) - to Enque;              |\n" +
                    "| (3) - to Deque;              |\n" +
                    "| (4) - to IsEmpty;            |\n" +
                    "| (5) - to IsFull;             |\n" +
                    "| (6) - to Print Buffer;       |\n" +
                    "| (7) - to Exit;               |\n" +
                    "================================="
                    );

                switch (Console.ReadLine())
                {
                    case "1":
                        queue = new Queue(InitBuffer());
                        break;
                    case "2":
                        queue.Enqueue();
                        break;
                    case "3":
                        queue.Dequeue();
                        break;
                    case "4":
                        if (queue.IsEmpty())
                        {
                            Console.WriteLine("IsEmpty buffer: true;");
                        }
                        else
                        {
                            Console.WriteLine("IsEmpty buffer: false;");
                        }
                        break;
                    case "5":
                        if (queue.IsFull())
                        {
                            Console.WriteLine("IsFull buffer: true;");
                        }
                        else
                        {
                            Console.WriteLine("IsFull buffer: false;");
                        }
                        break;
                    case "6":
                        queue.Print();
                        break;
                    case "7":
                        isExit = true;
                        break;
                    default:
                        Console.WriteLine("INVALID selection! Try again.\n\n");
                        break;
                }

                if (isExit)
                {
                    break;
                }
            }
            Console.WriteLine("Good bye!");
        }
    }
}
