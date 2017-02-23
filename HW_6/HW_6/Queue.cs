using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
    class Queue: Buffer
    {
        private int head, tail, counter;
        private Random rand = new Random();
        int[] buffer;

        public Queue(int[] array)
        {
            buffer = array;
            head = 0;
            tail = 0;
            counter = 0;
        }

        public void Enqueue()
        {
            if (IsEmpty())
            {
                buffer[tail] = rand.Next(-100, 100);
                Console.WriteLine("Enqueued value to buffer: {0} \n", buffer[tail]);
                tail++;
                counter++;
            }
            else if (IsTailAtTheEndOfBuffer() && !IsEmpty() && !IsFull())
            {
                buffer[tail] = rand.Next(-100, 100);
                Console.WriteLine("Enqueued value to buffer: {0}\n ", buffer[tail]);
                tail = 0;
                counter++;
            }
            else if (!IsTailAtTheEndOfBuffer() && !IsEmpty() && !IsFull())
            {
                buffer[tail] = rand.Next(-100, 100);
                Console.WriteLine("Enqueued value to buffer: {0} \n", buffer[tail]);
                tail++;
                counter++;
            }
            else if (IsFull())
            {
                Console.WriteLine("Sorry - the buffer is Full!\nEnque operation can't be performed.\n\n");
            }
        }

        public void Dequeue()
        {
            if (!IsEmpty() && IsHeadAtTheEndOfBuffer())
            {
                Console.WriteLine("Dequeued value is: {0}", buffer[head]);
                head = 0;
                counter--;
            }
            else if (!IsEmpty() && !IsHeadAtTheEndOfBuffer())
            {
                Console.WriteLine("Dequeued value is: {0}", buffer[head]);
                head++;
                counter--;
            }
            else if (IsEmpty())
            {
                Console.WriteLine("Sorry - the buffer is Empty!\nDeque operation can't be performed.\n\n");
            }
        }

        public bool IsFull()
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

        public bool IsEmpty()
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

        public bool IsHeadAtTheEndOfBuffer()
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

        public bool IsTailAtTheEndOfBuffer()
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

        public void Print()
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
