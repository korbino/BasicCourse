using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            BubbleSorter<DataContainer> bbSorterForDataContainer = new BubbleSorter<DataContainer>(InitDataContainerArray());
            Console.WriteLine("Array before sorting:");
            bbSorterForDataContainer.Print();
            bbSorterForDataContainer.Sort();
            Console.WriteLine("Array after BUBBLE sorting:");
            bbSorterForDataContainer.Print();

            InsertionSorter<DataContainer> insSorterDataContainer = new InsertionSorter<DataContainer>(InitDataContainerArray());
            Console.WriteLine("Array before sorting:");
            insSorterDataContainer.Print();
            insSorterDataContainer.Sort();
            Console.WriteLine("Array after Insertion sorting:");
            insSorterDataContainer.Print();

            Console.WriteLine("\n\n\n");
            QueueMenu(new MyQueue<DataContainer>(InitEmptyDataContainerArray()));
            Console.WriteLine("\n\n\n");
            StackMenu(new MyStack<DataContainer>(InitEmptyDataContainerArray()));

            Console.ReadLine();
        }

        /// <summary>
        /// Generating menu for the Queue
        /// </summary>
        /// <param name="myQueue">Recieving the object with queue(array of objects)</param>
        static void QueueMenu(MyQueue<DataContainer> myQueue)
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
                    "| (7) - to ShowPeek;           |\n" +
                    "| (8) - to Exit;               |\n" +
                    "================================="
                    );

                switch (Console.ReadLine())
                {
                    case "1":
                        myQueue = new MyQueue<DataContainer>(InitEmptyDataContainerArray());
                        break;
                    case "2":
                        Console.WriteLine("--Enter valid Int number:");
                        myQueue.Enqueue(NewDataContainerObj(ValidateInputNumberForIntValue(Console.ReadLine())));
                        break;
                    case "3":
                        try
                        {
                            Console.WriteLine("Dequeued value is: {0}", myQueue.Dequeue());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Sorry - the buffer is Empty!\nDeque operation can't be performed.\n\n");
                        }                        
                        break;
                    case "4":
                        if (myQueue.IsEmpty())
                        {
                            Console.WriteLine("IsEmpty buffer: true;");
                        }
                        else
                        {
                            Console.WriteLine("IsEmpty buffer: false;");
                        }
                        break;
                    case "5":
                        if (myQueue.IsFull())
                        {
                            Console.WriteLine("IsFull buffer: true;");
                        }
                        else
                        {
                            Console.WriteLine("IsFull buffer: false;");
                        }
                        break;
                    case "6":
                        myQueue.Print();
                        break;
                    case "7":                       
                        Console.WriteLine(myQueue.Peek());
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

        /// <summary>
        /// Generating menu for the Menu
        /// </summary>
        /// <param name="myStack">Recieving array of objects</param>
        static void StackMenu(MyStack<DataContainer> myStack)
        {
            bool isExit = false;

            while (true)
            {
                Console.WriteLine(
                    "=================================\n" +
                    "| (1) - to generate new Stack; |\n" +
                    "| (2) - to Push;               |\n" +
                    "| (3) - to Pop;                |\n" +
                    "| (4) - to IsEmpty;            |\n" +
                    "| (5) - to IsFull;             |\n" +
                    "| (6) - to Peek;               |\n" +
                    "| (7) - to Print myStack;      |\n" +
                    "| (8) - to Exit;               |\n" +
                    "================================="
                    );

                String UserSelection = Console.ReadLine();
                switch (UserSelection)
                {
                    case "1":
                        myStack = new MyStack<DataContainer>(InitEmptyDataContainerArray());
                        break;
                    case "2":
                        Console.WriteLine("--Enter Valid int value:");
                        myStack.Push(NewDataContainerObj(ValidateInputNumberForIntValue(Console.ReadLine())));                        
                        break;
                    case "3":
                        try
                        {
                            Console.WriteLine("{0}\n\n", myStack.Pop());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Sorry - stack is empty.\n\n");
                        }
                        break;
                    case "4":
                        if (myStack.IsEmpty())
                        {
                            Console.WriteLine("Stack is Empty: true\n");
                        }
                        else
                        {
                            Console.WriteLine("Stack is not Empty: false\n");
                        }
                        break;
                    case "5":
                        if (myStack.IsFull())
                        {
                            Console.WriteLine("Stack is Full: true.\n");
                        }
                        else
                        {
                            Console.WriteLine("Stack is Full: false.\n");
                        }
                        break;
                    case "6":
                        try
                        {
                            Console.WriteLine("{0}\n\n", myStack.Peek());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Looks like the peek is looking \nfor the first element of the stack, \nand it is empty. \n\n");
                        }                    
                        break;
                    case "7":
                        myStack.Print();
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
            Console.WriteLine("Good Luck....");            
        }

        /// <summary>
        /// This method is generating array of DataContainer objects with size 10
        /// </summary>
        /// <returns>Array of DataContainer objects</returns>
        static DataContainer[] InitDataContainerArray()
        {
            Console.WriteLine("Init DataContainer Array:>>>>>>");
            DataContainer[] array = new DataContainer[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (new DataContainer(rand.Next(-100, 100)));
            }
            return array;
        }

        /// <summary>
        /// This method is generating empty array with Datacontainer type
        /// </summary>
        /// <returns>Empty DataContainer array</returns>
        static DataContainer[] InitEmptyDataContainerArray()
        {
            Console.WriteLine("Init empty DataContainer Array: >>>");
            DataContainer[] array = new DataContainer[10];
            return array;
        }

        /// <summary>
        /// Generating new DataContainer object
        /// </summary>
        /// <param name="number">recieving int value</param>
        /// <returns>new DataContainer object</returns>
        static DataContainer NewDataContainerObj(int number)
        {
            return new DataContainer(number);
        }

        /// <summary>
        /// This method goiong to loop, untill you'll enter valid int value
        /// </summary>
        /// <param name="value">read value from console</param>
        /// <returns>validated int value</returns>
        static int ValidateInputNumberForIntValue(String value)
        {
            int result;
            while (true)
            {
                if (IsItInteger(value))
                {
                    result = Convert.ToInt32(value);
                    break;
                }
                else
                {
                    Console.WriteLine("You entered not valid value, please reentere it again:");
                    value = Console.ReadLine();
                }
            }
            return result;
        }

        /// <summary>
        /// Parsing string for int.
        /// </summary>
        /// <param name="value">String</param>
        /// <returns>In case of string contain only int number - return true and vise versa</returns>
        static bool IsItInteger(String value)
        {
            int number;
            if (int.TryParse(value, out number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
