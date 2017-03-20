using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: Learn 10 shortcuts from studia...
 
namespace newHW_8_sorting_of_2D_array_
{
    class Program
    {
        static int[,] current2DArray;

        static void Main(string[] args)
        {            
            ShowMenu();                       
        }
        //TODO:showmenu should recieve param (array, objects of sorters(list "ISorter" type))
        static void ShowMenu()
        {            
            //objects and fields init:            
            bool uRAlive = true;
            ArrayGenerator arrayGen = new ArrayGenerator();
            current2DArray = arrayGen.Generate2DArray(10, 2);
            ISorter bbSorter = new BubleSorter();
            ISorter insSorter = new InsertionSorter();
            ISorter defSorter = new DefaultSorter();
            ISorter selSorter = new SelectionSorter();

            //Menu:
            //TODO: replace while "true"
            while (uRAlive)
            {
                Console.WriteLine(
                    "\n\n======Choose your actions:=================\n" +
                    "| (1) - Generate new 2D array             |\n" +
                    "| (2) - Bubble sort: from Min To Max      |\n" +
                    "| (3) - Bubble sort: from Max to Min      |\n" +
                    "| (4) - Insertion Sort: from Min to Max   |\n" +
                    "| (5) - Insertion Sort: from Max to Min   |\n" +
                    "| (6) - Selection Sort: from Min to Max   |\n" +
                    "| (7) - Selection Sort: from Max to Min   |\n" +
                    "| (8) - Default Sort: from Min to Max     |\n" +
                    "| (9) - Default Sort: from Max to Min     |\n" +
                    "| (10) - PrintCurrent2DArray current array2D            |\n" +
                    "==========================================="
                    );

                switch (Console.ReadLine())
                {//TODO: spelling mistakes, rename objects to m
                    case "1":
                        current2DArray = arrayGen.Generate2DArray(10, 2);
                        Console.WriteLine("**New 2D array was generated. \n**To check it - please choose PrintCurrent2DArray item in below ShowMenu.");
                        break;
                    case "2":
                        Console.WriteLine("**You choosed Bubble sort: from Min to Max. \n**PrintCurrent2DArray it - to check.");
                        current2DArray = bbSorter.Sort(current2DArray, true);
                        break;
                    case "3":
                        Console.WriteLine("**You choosed Bubble sort: from Max to Min. \n**PrintCurrent2DArray it - to check.");
                        current2DArray = bbSorter.Sort(current2DArray, false);
                        break;
                    case "4":
                        Console.WriteLine("**You choosed Insertion sort: from Min to Max. \nPrintCurrent2DArray it - to check.");
                        current2DArray = insSorter.Sort(current2DArray, true);
                        break;
                    case "5":
                        Console.WriteLine("**You choosed Insertion sort: from Max to Min. \nPrintCurrent2DArray it - to check.");
                        current2DArray = insSorter.Sort(current2DArray, false);
                        break;
                    case "6":
                        Console.WriteLine("**You choosed Selection* sort: from Min to Max. \nPrintCurrent2DArray it - to check.");
                        current2DArray = selSorter.Sort(current2DArray, true);
                        break;
                    case "7":
                        Console.WriteLine("**You choosed Selection* sort: from Max to Min. \nPrintCurrent2DArray it - to check.");
                        current2DArray = selSorter.Sort(current2DArray, false);
                        break;
                    case "8":
                        Console.WriteLine("**You choosed Default sort: from Min to Max. \nPrintCurrent2DArray it - to check.");
                        current2DArray = defSorter.Sort(current2DArray, true);
                        break;
                    case "9":
                        Console.WriteLine("**You choosed Default sort: from Max to Min. \nPrintCurrent2DArray it - to check");
                        current2DArray = defSorter.Sort(current2DArray, false);
                        break;
                    case "10":
                        PrintCurrent2DArray();
                        break;
                    default:
                        Console.WriteLine("You entered not correct value. \n Please try again.");
                        break;
                }
            }
        }
        //TODO: print like 2D
        static void PrintCurrent2DArray()
        {
            Console.WriteLine("Current state of 2D array:");
            foreach (int val in current2DArray)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine("\n\n");
        }
    }
}
