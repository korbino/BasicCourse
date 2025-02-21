﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newHW_8_sorting_of_2D_array_
{
    class InsertionSorter : BaseSorter, ISorter
    {        
        public int[] Sort(int[] array, bool isSortingFromMinToMax)
        {           
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    if ((array[j + 1] < array[j]) && isSortingFromMinToMax)
                    {
                        Swap(array, j, j + 1);
                    }
                    //inverse logic                        
                    else if ((array[j + 1] > array[j] && !isSortingFromMinToMax))
                    {
                        Swap(array, j, j + 1);                       
                    }
                }
            }
            return array;
        }

        public override string ToString()
        {
            return "InsertionSorter";
        }
    }
}
