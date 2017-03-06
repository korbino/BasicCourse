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

        public DataContainer(int intValue)
        {
            this.IntValue = intValue;
        }

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


