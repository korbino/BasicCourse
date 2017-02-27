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
            //TODO: implement validation
            DataContainer dt = obj as DataContainer;

            if (this.IntValue > dt.IntValue)
            {
                return 1;
            }
            if (this.IntValue < dt.IntValue)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return Convert.ToString(IntValue);
        }
    }
}
