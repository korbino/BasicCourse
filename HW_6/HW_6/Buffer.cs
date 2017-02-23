using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
    class Buffer
    {
        /// <summary>
        /// This method will check if [array] is Full
        /// Will be overriden for each class: Stack\Queue
        /// </summary>
        /// <returns>boolean</returns>
       virtual public bool IsFull()
        {
            return true;
        }

       /// <summary>
       /// This method will check if [array] is Empty
       /// Will be overriden for each class: Stack\Queue
       /// </summary>
       /// <returns>boolean</returns>
        virtual public bool IsEmpty()
        {
            return true;
        }

        /// <summary>
        /// This method goiong to loop, untill you'll enter valid int value
        /// </summary>
        /// <param name="value">read value from console</param>
        /// <returns>validated int value</returns>
        protected int ValidateInputNumberForIntValue(String value)
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
        private bool IsItInteger(String value)
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
