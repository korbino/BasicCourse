using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7
{
    class MyQueue<T> : Buffer<T>, IMyQueue<T>
    {
        private int head, tail, counter;
        private Random rand = new Random();
        T[] buffer;

        public MyQueue(T[] array)
        {
            buffer = array;
            head = 0;
            tail = 0;
            counter = 0;
        }

        public void Enqueue(T incomingObject)
        {                       
            if (IsEmpty())
            {
                //buffer[tail] = ValidateInputNumberForIntValue(Console.ReadLine());
                buffer[tail] = incomingObject;
                Console.WriteLine("Enqueued value to buffer: {0} \n", buffer[tail]);

                tail++;
                counter++;
            }
            else if (IsTailAtTheEndOfBuffer() && !IsEmpty() && !IsFull())
            {                
                buffer[tail] = incomingObject;
                Console.WriteLine("Enqueued value to buffer: {0}\n ", buffer[tail]);
                tail = 0;
                counter++;
            }
            else if (!IsTailAtTheEndOfBuffer() && !IsEmpty() && !IsFull())
            {                
                buffer[tail] = incomingObject;
                Console.WriteLine("Enqueued value to buffer: {0} \n", buffer[tail]);
                tail++;
                counter++;
            }
            else if (IsFull())
            {
                Console.WriteLine("Sorry - the buffer is Full!\nEnque operation can't be performed.\n\n");
            }
        }
      
        public int Dequeue()
        {
            int result = 0;
            bool isEmpty = false;
            if (!IsEmpty() && IsHeadAtTheEndOfBuffer())
            {                
                result = Convert.ToInt32(buffer[head]);      
                head = 0;
                counter--;
            }
            else if (!IsEmpty() && !IsHeadAtTheEndOfBuffer())
            {                
                result = Convert.ToInt32(Convert.ToString(buffer[head]));
                head++;
                counter--;
            }
            else if (IsEmpty())
            {
                isEmpty = true;                
            }

            //Make decision: in case of queue is empty - throw exception and catch it in Programm class.
            //Return int result in opposit case.
             if (isEmpty)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                return result;
            }
        }

        public override bool IsFull()
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

        public override bool IsEmpty()
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

        public override void Print()
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
        
        public override int Peek()
        {
            return Convert.ToInt32(buffer[head]);
        }
    }
}
