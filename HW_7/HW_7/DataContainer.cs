using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7
{
    class DataContainer : IComparable
    {

        public int IntValue { set; get; }

        /// <summary>
        /// Thsi is data container calss, which is holding one INT field
        /// </summary>
        /// <param name="intValue">int value</param>
        public DataContainer(int intValue)
        {
            this.IntValue = intValue;
        }

        /// <summary>
        /// Comparing two objects (itself)
        /// </summary>
        /// <param name="obj">object to compare</param>
        /// <returns>return 1 in case local object > incoming
        /// return -1 in case of local object < incoming
        /// return 0 in case of local object == to incoming</returns>
        public int CompareTo(Object obj)
        {
            DataContainer dc = obj as DataContainer;

            if (dc != null)
            {
                if (this.IntValue > dc.IntValue)
                {
                    return 1;
                }
                if (this.IntValue < dc.IntValue)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public override string ToString()
        {
            return Convert.ToString(IntValue);
        }
    }
}


