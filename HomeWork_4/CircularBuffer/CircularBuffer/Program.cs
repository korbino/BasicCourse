using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularBuffer
{
    class Program
    {        
        static int head, tail;
        static Random rand = new Random();

        static void Main(string[] args)
        {

        }
        
        
        
        
        //TODO:
        static void Menu(int[] buffer)
        {

        }
        
        static int[] InitBuffer(){
            int[] buffer = new int[10];
            head = 0;
            tail = 0;
            return buffer;
        }

        static void Enqueue(int[] buffer)
        {
            if (IsEmpty(buffer)){
                buffer[head] = rand.Next(-100, 100);                
            }            
            else if(!IsEmpty(buffer) && !IsFull(buffer) && !IsHeadAtTheEndOfBuffer(buffer)){
                head ++;
                buffer[head] = rand.Next(-100, 100);
            }
            else if (!IsEmpty(buffer) && !IsFull(buffer) && IsHeadAtTheEndOfBuffer(buffer))
            {
                head = 0;
                buffer[head] = rand.Next(-100, 100);
            }            
            
            else if (IsFull(buffer))
            {
                Console.WriteLine("Sorry - the buffer is Full!\n");
            }
        }

        //TODO:
        static void Dequeue(int[] buffer)
        {

        }

        //TODO:
        static bool IsFull(int[] buffer)
        {

            return true;
        }
        
        static bool IsEmpty(int[] buffer)
        {
            if (head == tail)
            {
                Console.WriteLine("IsEmptyBuffer: true\n");
                return true;
            }
            else
            {
                Console.WriteLine("IsEmptyBuffer: false\n");
                return true;
            }            
        }
        
        static bool IsHeadAtTheEndOfBuffer(int[] buffer)
        {
            if (head == buffer.Length - 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
