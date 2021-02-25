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
            Console.WriteLine(@"                                             Welcome to
            ____________________________       ______________  _________ ________ ________ 
            __  ___/___  ____/___  ____/       __  ___/___  / / /___    |___  __ \___  __ \
            _____ \ __  __/   __  __/          _____ \ __  /_/ / __  /| |__  /_/ /__  /_/ /
            ____/ / _  /___   _  /___          ____/ / _  __  /  _  ___ |_  _, _/ _  ____/ 
            /____/  /_____/   /_____/          /____/  /_/ /_/   /_/  |_|/_/ |_|  /_/      
                                                                               
                                 ________        ______                                    
                                 __  ___/______ ____  /_____ ________                      
                                 _____ \ _  __ `/__  / _  _ \__  ___/                      
                                 ____/ / / /_/ / _  /  /  __/_(__  )                       
                                 /____/  \__,_/  /_/   \___/ /____/
                                 ");
            Console.WriteLine("\nTo get started, type in the path to the file you want to analyse");
            filepath = Console.ReadLine();
            return filepath;
        }

       

        
        public enum FileType { csv = 1, xml = 2, json = 3 }
        
        
        public static void CheckIfFileIsValid()
        {
            var types = Enum.GetValues(typeof(FileType)) as FileType[];
           
            foreach (var type in types)
            {
                if (filepath.EndsWith(type.ToString()))
                {
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

            Console.WriteLine("\n Press 1 to display file");
            Console.WriteLine("\n Press 2 to Search for Country and Item Type");
            Console.WriteLine("\n Press 3 to search for Order ID");
            Console.WriteLine("\n Press 4 to se total sales in different regions");
            Console.WriteLine("\n Press 5 to display and export file in JSON format");


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
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Do you want to see the menu again? press y for yes and n to exit");
            try
            {
                char answer = char.Parse(Console.ReadLine());
            
                if (answer == 'y')
                {
                    exit = false;
                }
                else
                {
                    exit = true;
                }
            }
            catch { }

            Console.Clear();

        }
    }
}
