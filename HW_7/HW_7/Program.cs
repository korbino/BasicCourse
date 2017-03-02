using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_7
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            BubbleSorter<DataContainer> bbSorterForDataContainer = new BubbleSorter<DataContainer>(InitDataContainerArray());
            bbSorterForDataContainer.Print("Array before sorting:");
            bbSorterForDataContainer.Sort();
            bbSorterForDataContainer.Print("Array after BUBBLE sorting:");

            InsertionSorter<DataContainer> insSorterDataContainer = new InsertionSorter<DataContainer>(InitDataContainerArray());
            insSorterDataContainer.Print("Array before sorting:");
            insSorterDataContainer.Sort();
            insSorterDataContainer.Print("Array after Insertion sorting:");


            Console.ReadLine();
        }


        static DataContainer[] InitDataContainerArray()
        {
            Console.WriteLine("Init DataContainer Array:>>>>>>");
            DataContainer[] array = new DataContainer[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (new DataContainer(rand.Next(-100, 100)));
            }
            return array;
        }
    }
}
