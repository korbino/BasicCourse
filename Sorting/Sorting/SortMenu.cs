using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sorting
{
    class SortMenu
    {
        private int[,] current2DArray;
        private int[] current1DArray;
        private int userSelectionMainMenu;
        private bool isAscSorting;
        private String sortingModePrefix;
        private static object locker = new object();
        private List<ISorter> sorterList;
        private int counterForOutputs = 0;
        //private int[] tmpArray;        

        public SortMenu(List<ISorter> sorterList)
        {
            this.sorterList = sorterList;
        }

        public void ShowMenu()
        {
            //objects and fields init:            
            bool isExit = false;
            current2DArray = SortUtil.Generate2DArray(10, 10);

            //Menu:            
            while (!isExit)
            {
                //Menu generator:
                Console.Clear();
                int sorterListMenuItemCounter = 4;

                //TODO: create array of string and print
                Console.WriteLine(
                    "\t\tChoose your actions:\n" +
                    "(1) - Generate new custom 2D array\n" +
                    "(2) - Print 2D array\n" +
                    "(3) - Sort simultaneously with all sorters and print to console, once it will be sorted"
                    );

                //generating dynamic menu, according to incoming List of sorters
                foreach (ISorter sorter in sorterList)
                {
                    Console.WriteLine("({0}) - {1}", sorterListMenuItemCounter, sorter);
                    sorterListMenuItemCounter++;
                }

                //Display last step - exit
                Console.WriteLine("({0}) - Exit", sorterList.Count + 4);

                //Reading user selection and parse for correct value:
                userSelectionMainMenu = SortUtil.ValidateInputNumberForIntValue(Console.ReadLine(), 1, sorterList.Count + 4);

                //User selection 1-3 handler:
                switch (userSelectionMainMenu)
                {
                    case 1:
                        MenuDialog_GenerateNew2DArray();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Please see below printed 2D array:\n\n");
                        SortUtil.Print2DArrayToConsole(current2DArray);
                        Console.WriteLine("To continue, please press any key...");
                        Console.ReadKey();
                        break;
                    case 3:
                        MenuDialog_SortingMenuHandler(true);
                        break;
                    default:
                        break;
                }

                //sub menu (for list of sorters) selection, in case of user selected sorting methods:                
                if (Enumerable.Range(4, sorterList.Count).Contains(userSelectionMainMenu))
                {
                    MenuDialog_SortingMenuHandler(false);
                }

                //exit logic
                else if (userSelectionMainMenu == sorterList.Count + 4)
                {
                    isExit = true;
                }
            }
        }


        //<<Menu dialog section:>>
        //
        private void MenuDialog_GenerateNew2DArray()
        {
            Console.Clear();
            Console.WriteLine("\tGenerating new 2D array: \n\nPlease enter number of rows (1 - 1000):");
            int customNumberOfRows = SortUtil.ValidateInputNumberForIntValue(Console.ReadLine(), 1, 1000);

            Console.WriteLine("Please enter number of columns (1 - 1000):");
            int customNumberOfColumns = SortUtil.ValidateInputNumberForIntValue(Console.ReadLine(), 1, 1000);

            current2DArray = SortUtil.Generate2DArray(customNumberOfRows, customNumberOfColumns);
            Console.WriteLine("New 2D array was generated. \nTo continue, please press any key...");
            Console.ReadKey();
        }

        



        //split to few small 
        private void MenuDialog_SortingMenuHandler(bool isSortWithAllSortersSimultaneously)
        {
            //define prefix for sorting mode description
            if (isSortWithAllSortersSimultaneously)
            {
                sortingModePrefix = "All sorters simultaneously";
            }
            else
            {
                sortingModePrefix = Convert.ToString(sorterList.ElementAt(userSelectionMainMenu - 4));
            }

            Console.Clear();
            Console.WriteLine(
                "           You've chosen <<{0}>>.\n" +
                "           Please do you selection:\n" +
                "(1) - Sorting in Asc\n" +
                "(2) - Sorting in Desc\n",
                sortingModePrefix
                );

            //read sorting sub menu selection and define Asc\Desc sort mode
            int userSelectionSubMenu = SortUtil.ValidateInputNumberForIntValue(Console.ReadLine(), 1, 2);
            if (userSelectionSubMenu == 1)
            {
                isAscSorting = true;
            }
            else
            {
                isAscSorting = false;
            }

            current1DArray = SortUtil.Convert2DArrayTo1D(current2DArray);

            //run sorting itself. In multithreads, or in single.
            if (isSortWithAllSortersSimultaneously)
            {
                                

                foreach (ISorter sorter in sorterList)
                {
                   
                    Stopwatch stopWatch = new Stopwatch();

                    //init thread
                    Thread sorterThread = new Thread(
                        () =>
                        {
                            stopWatch.Start();
                            sorter.Sort((int[])current1DArray.Clone(), isAscSorting);

                            stopWatch.Stop();                            
                        });
                    sorterThread.Start();
                }                
                //wait untill all results will be printed to screen
                while (counterForOutputs < sorterList.Count)
                {                   
                }
            }
            else
            {
                current1DArray = sorterList.ElementAt(userSelectionMainMenu - 4).Sort(current1DArray, isAscSorting);
                current2DArray = SortUtil.Convert1DArraTo2D(current1DArray, current2DArray.GetLength(0), current2DArray.GetLength(1));
            }
            Console.WriteLine("Array was sorted with <<{0}>>. \nPlease press anykey get back to Main menu....", sortingModePrefix);
            Console.ReadKey();
        }
       
        //subscriber method       
        public void OnArrayWasSorted(ArrayWasSortedEventArgs args)
        {
            lock (locker)
            {
                Console.WriteLine("\n\nArray was sorted with:<{0}>. \nWith Elapsed time:<{1}>: \n______", args.SorterName, args.stopWatch.Elapsed);
                SortUtil.Print2DArrayToConsole(SortUtil.Convert1DArraTo2D(args.Array1D, current2DArray.GetLength(0), current2DArray.GetLength(1)));
                counterForOutputs++;           
            }           
        }
    }
}
