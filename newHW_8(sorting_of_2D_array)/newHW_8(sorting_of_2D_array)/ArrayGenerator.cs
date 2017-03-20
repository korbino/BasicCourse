using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newHW_8_sorting_of_2D_array_
{
    class ArrayGenerator
    {       
        Random rand = new Random();
        
        //TODO: make method to Static
        public int[,] Generate2DArray(int dim_1, int dim_2)
        {
            int[,] array = new int [dim_1,dim_2];
            for (int i = 0; i < dim_1;  i++)
            {
                for (int j = 0; j < dim_2; j++)
                {
                    array[i, j] = rand.Next(-100, 100);
                }
            }            
    
            return array;        
        }
    }
}
