using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularBuffer
{
    class Program
    {        
        static int head, tail, counter;
        static Random rand = new Random();
        static bool isBufferNew;


        static void Main(string[] args)
        {
            Menu(InitBuffer());
        }
        
        
        
                
        static void Menu(int[] buffer)
        {
            while (true){
                Console.WriteLine(
                    "=================================\n" +
                    "| (1) - to init new Buffer;    |\n" +
                    "| (2) - to Enque;              |\n" +
                    "| (3) - to Deque;              |\n" +
                    "| (4) - to IsEmpty;            |\n" +
                    "| (5) - to IsFull;             |\n" +
                    "| (6) - to Print Buffer;       |\n" +                    
                    "================================="
                    );
            
            switch (Console.ReadLine())
            {
                case "1":
                    buffer = InitBuffer();
                    break;
                case "2":
                    Enqueue(buffer);
                    break;
                case "3":
                    Dequeue(buffer);
                    break;
                case "4":
                    if (IsEmpty(buffer))
                    {
                        Console.WriteLine("IsEmpty buffer: true;");
                    }
                    else
                    {
                        Console.WriteLine("IsEmpty buffer: false;");
                    }
                    break;
                case "5":
                    if (IsFull(buffer))
                    {
                        Console.WriteLine("IsFull buffer: true;");
                    }
                    else
                    {
                        Console.WriteLine("IsFull buffer: false;");
                    }
                    break;
                case "6":
                    PrintBuffer(buffer);
                    break;
                default:
                    Console.WriteLine("INVALID selection! Try again.\n\n");
                break;
            }   
            }       
        }
        
        static int[] InitBuffer(){
            int[] buffer = new int[10];
            head = 0;
            tail = 0;
            counter = 0;
            isBufferNew = true;
            return buffer;
        }
       
        static void Enqueue(int[] buffer)
        {
            if (IsEmpty(buffer))
            {
                buffer[tail] = rand.Next(-100, 100);                
                Console.WriteLine("Enqueued value to buffer: {0} \n", buffer[tail]);
                tail++;
                counter++;
            }
            else if (IsTailAtTheEndOfBuffer(buffer) && !IsEmpty(buffer) && !IsFull(buffer))
            {
                buffer[tail] = rand.Next(-100, 100);
                Console.WriteLine("Enqueued value to buffer: {0}\n ", buffer[tail]);
                tail = 0;
                counter++;
            }
            else if (!IsTailAtTheEndOfBuffer(buffer) && !IsEmpty(buffer) && !IsFull(buffer))
            {
                buffer[tail] = rand.Next(-100, 100);
                Console.WriteLine("Enqueued value to buffer: {0} \n", buffer[tail]);
                tail++;
                counter++;
            }
            else if (IsFull(buffer))
            {
                Console.WriteLine("Sorry - the buffer is Full!\nEnque operation can't be performed.\n\n");
            }
        }
 
        //TODO:
        static void Dequeue(int[] buffer)        
    {
            if (!IsEmpty(buffer) && IsHeadAtTheEndOfBuffer(buffer))
            {
                Console.WriteLine("Dequeued value is: {0}", buffer[head]);
                head = 0;
                counter--;                
            }
            else if (!IsEmpty(buffer) && !IsHeadAtTheEndOfBuffer(buffer))
            {
                Console.WriteLine("Dequeued value is: {0}", buffer[head]);
                head++;
                counter--;
            }
            else if (IsEmpty(buffer)){
                Console.WriteLine("Sorry - the buffer is Empty!\nDeque operation can't be performed.\n\n");
            }
        }
        
        static bool IsFull(int[] buffer)
        {
            if (counter == buffer.Length)
            {                
                return true;
            }
            else
            {
                return false;
            }            
        }
               
        static bool IsEmpty(int[] buffer)
        {
            if (counter == 0)
            {                
                return true;
            }
            else
            {                
                return false;
            }            
        }
        
        static bool IsHeadAtTheEndOfBuffer(int[] buffer)
        {
            if (head == buffer.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsTailAtTheEndOfBuffer(int[] buffer)
        {
            if (tail == buffer.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //TODO:
        static void PrintBuffer(int[] buffer)
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                Console.Write("buffer[{0}]: {1}", i, buffer[i]);
                if (head == i)
                {
                    Console.Write("    <--head  ");
                }
                if (tail == i)
                {
                    Console.Write("    <--tail  ");
                }
                Console.WriteLine();                     
            }
        }   
    }
}
