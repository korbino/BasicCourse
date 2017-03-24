using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace newHW_8_sorting_of_2D_array_
{
    class Program
    {
        static int[,] current2DArray;
        static int[] current1DArray;

        static void Main(string[] args)
        {
            //init list of sorters
            List<ISorter> sorterList = new List<ISorter> {
                new BubleSorter(),
                new InsertionSorter(),
                new DefaultSorter(),
                new SelectionSorter()            
            };            

            ShowMenu(sorterList);                       
        }
        
        static void ShowMenu(List<ISorter> listOfSorters)
        {            
            //objects and fields init:            
            bool isExit = false;            
            current2DArray = SortUtil.Generate2DArray(10, 10);                      

            //Menu:
            //TODO: replace while "true"
            while (!isExit)
            {
                //TODO: generating dynamic menu:
                //Menu generator:
                Console.Clear();
                int sorterListMenuItemCounter = 4;
                bool isAscSorting;
                Console.WriteLine(
                    "           Choose your actions:\n" +                    
                    "(1) - Generate new 2D array\n" +
                    "(2) - Print 2D array\n" +
                    "(3) - Sort simultaneously with all sorters (NOT READY YET)"                    
                    );
                //generating dynamic menu, according to incoming List of sorters
                foreach (ISorter sorter in listOfSorters)
                {
                    Console.WriteLine("({0}) - {1}", sorterListMenuItemCounter, sorter);                    
                    sorterListMenuItemCounter ++;
                }
                //Last step - exit
                Console.WriteLine("({0}) - Exit", listOfSorters.Count + 4);


                //actions according to user selection.
                int userSelectionMainMenu = ValidateInputNumberForIntValue(Console.ReadLine(),1,listOfSorters.Count+4);

                //if (userSelectionMainMenu >= 0 && userSelectionMainMenu <= 3)
                if(Enumerable.Range(1,3).Contains(userSelectionMainMenu))
                {
                    switch (userSelectionMainMenu)
                    {
                        case 1:
                            current2DArray = SortUtil.Generate2DArray(10, 10);
                            Console.Clear();
                            Console.WriteLine("New 2D array was generated. \nTo continue, please press any key...");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Please see below printed 2D array:\n\n");
                            SortUtil.Print2DArrayToConsole(current2DArray);
                            Console.WriteLine("To continue, please press any key...");
                            Console.ReadKey();
                            break;
                        //TODO: here will be writting simulateously generating.
                        case 3:
                            break;

                        default:
                            Console.WriteLine("You entered not correct value. \n Please try again.");
                            break;
                    }                
                }

                //sub menu (for list of sorters) selection, in case of user selected sorting methods:
                //else if((userSelectionMainMenu >= 4) || (userSelectionMainMenu <= listOfSorters.Count))
                else if (Enumerable.Range(4,listOfSorters.Count).Contains(userSelectionMainMenu))
                {
                    Console.Clear();
                    Console.WriteLine(
                        "           You've chosen {0}.\n" +
                        "           Please do you selection:\n" +
                        "(1) - Sorting in Asc\n" +
                        "(2) - Sorting in Desc\n",
                        listOfSorters.ElementAt(userSelectionMainMenu - 4)
                        );

                    //read sorting sub menu selection and define Asc\Desc sort mode
                    int userSelectionSubMenu = ValidateInputNumberForIntValue(Console.ReadLine(),1,2);
                    if (userSelectionSubMenu == 1)
                    {
                        isAscSorting = true;
                    }
                    else
                    {
                        isAscSorting = false;
                    }

                    current1DArray = SortUtil.Convert2DArrayTo1D(current2DArray);
                    current1DArray = listOfSorters.ElementAt(userSelectionMainMenu - 4).Sort(current1DArray,isAscSorting);
                    current2DArray = SortUtil.Convert1DArraTo2D(current1DArray, current2DArray.GetLength(0),current2DArray.GetLength(1));
                    Console.WriteLine("Array was sorted with {0}. \nPlease press anykey get back to Main menu....", listOfSorters.ElementAt(userSelectionMainMenu - 4));
                    Console.ReadKey();        
                }                                

                //exit logic
                if (userSelectionMainMenu == listOfSorters.Count + 4)
                {
                    isExit = true;
                }
            }
        }

        /// <summary>
        /// This method goiong to loop, untill you'll enter valid int value
        /// </summary>
        /// <param name="value">read value from console</param>
        /// <returns>validated int value</returns>
        static int ValidateInputNumberForIntValue(String value, int min, int max)
        {
            int result;
            while (true)
            {
                if (IsItInteger(value))
                {
                    result = Convert.ToInt32(value);
                    //if (result >= min && result <= max)
                    if(Enumerable.Range(min,max).Contains(result))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You entered not valid value, please reentere it again:");
                        value = Console.ReadLine();
                    }
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
        static bool IsItInteger(String value)
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
