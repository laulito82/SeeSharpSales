using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace SeeSharpSales
{
    public class UserMenu
    {
        public static string filepath;
       
        public static string ChooseFileToAnalyse()
        {
            Console.WriteLine(" SSSS EEE  EEE   SSSS  H   H   A    RRR    PPP");
            Console.WriteLine("S     E    E    S      H   H  A  A  R  R   P   P");
            Console.WriteLine(" SSS  EE   EE    SSS   HHHHH  AAAA  RRR    PPP");
            Console.WriteLine("    S E    E        S  H   H  A  A  R  R   P");
            Console.WriteLine("SSSS  EEE  EEE  SSSS   H   H  A  A  R   R  P");
            Console.WriteLine("\nTo get started, type in the path to the file you want to analyse");
            filepath = Console.ReadLine();
            return filepath;
        }

       

        
        public enum FileType { csv = 1, xml = 2, json = 3 }
        
        // Det jeg prøver åpå er å gå gjennom enums som jeg har laget og for hver av de skal det sjekkes om filepath ender med en av enumene 
        public static void CheckIfFileIsValid()
        {
            var types = Enum.GetValues(typeof(FileType)) as FileType[];
           
            foreach (var type in types)
            {
                if (filepath.EndsWith(type.ToString()))
                {
                    Console.WriteLine($" You entered {filepath}. This file is good to go. Press enter to continue.");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid filename. Press enter to exit and try again");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
        }
        
        
       

        public static void DisplayMenu()
        {
            Console.Clear();
            

            Console.WriteLine("-------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"   Menu for: {filepath}      ");
            Console.ResetColor();

            Console.WriteLine("-------------------------------------------");

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n Theese are your options:");
            Console.ResetColor();

            Console.WriteLine("\n Press 1 to print to json format");

            Console.WriteLine("\n Press 2 to se total sales in different regions");

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


        public static bool exit;

        public static void ExitOrRunNew()
        {
            Console.WriteLine("Do you want to see the menu again? press y for yes and n to exit");
            char answer = char.Parse(Console.ReadLine());

            if (answer == 'y')
            {
                exit = false;
            }

            else
            {
                exit = true;
            }

            Console.Clear();

        }
    }
}
