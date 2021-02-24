using System;
using System.Collections.Generic;
using System.Text;

namespace SeeSharpSales
{
    public class UserMenu
    {
        public static string filepath;

        public static string ChooseFileToAnalyse()
        {
            Console.WriteLine("Welcome to SeeSharpSale, your trusted salesrecordsanalyser! \nTo get started, type in the path to the file you want to analyse");
            filepath = Console.ReadLine();

            //to be done check if the filename is valid and if it is reurn the  filepath so we can use it in main
            return filepath;
        }

        //kodebit for å bruke i main i stede for @blablabal:
        //ReadFile(UserMenu.filepath, listSalesRecords);
       

        public static void DisplayMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("                  Menu                     ");
            Console.WriteLine("-------------------------------------------");

            Console.ResetColor();

            Console.WriteLine("\nTheese are your options:");

            Console.WriteLine("\n Press 1 to print report");

            Console.WriteLine("\n Press 2 to se possible calculations");

            Console.WriteLine("\n Press 3 write to different fileformat");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine("\n-------------------------------------------");

            Console.ResetColor();
        }

        public static int GetUserInput()
        {
            int selectedOption = 0;

            try
            {
                selectedOption = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input. Please try again:");
                GetUserInput();
            }

            return selectedOption;
        }

        public static void RunMenuOption(int selectedOption)
        {


            switch (selectedOption)
            {

                case 1: //test 1 Hello
                    FirstOptionForTest();
                    break;

                case 2: 
                    Console.Clear();
                    Console.WriteLine("You choose 2");
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("You choose 3");
                    break;

                default:
                    DisplayMenu();
                    break;
            }

            static void FirstOptionForTest()
            {
                Console.Clear();
                Console.WriteLine("Hei");
            }
        }
    }
}
