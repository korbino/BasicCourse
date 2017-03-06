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

        /// <summary>
        /// This class is simulating Queue logic
        /// </summary>
        /// <param name="array">array of objects</param>
        public MyQueue(T[] array)
        {
            buffer = array;
            head = 0;
            tail = 0;
            counter = 0;
        }

        /// <summary>
        /// Writing to queue new object in case of there is avaliable place
        /// </summary>
        /// <param name="incomingObject">new object</param>
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
      
        /// <summary>
        /// Extructing avaliable object from Queue
        /// </summary>
        /// <returns>object</returns>
        public T Dequeue()
        {                        
            if (!IsEmpty() && IsHeadAtTheEndOfBuffer())
            {                
                return buffer[head];      
                head = 0;
                counter--;
            }
            else if (!IsEmpty() && !IsHeadAtTheEndOfBuffer())
            {                                                
                counter--;
                T obj = buffer[head];
                head++;
                return obj;
            }
            else if (IsEmpty())
            {
                throw new IndexOutOfRangeException();                
            }
            else
            {
                return buffer[head];
            }
        }

        /// <summary>
        /// Check if queue is empty
        /// </summary>
        /// <returns>boolean value</returns>
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

        /// <summary>
        /// Check if queue is full
        /// </summary>
        /// <returns>boolean value</returns>
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

        /// <summary>
        /// Check if head placed at the end of Buffer
        /// </summary>
        /// <returns>boolean value</returns>
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

        /// <summary>
        /// Check if tail placed at the end of queue
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Print to console the queue, with head\tail tags
        /// </summary>
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
        
        /// <summary>
        /// Show avaliable to Dequeue value
        /// </summary>
        /// <returns>object</returns>
        public override T Peek()
        {
            return buffer[head];
        }
    }
}
