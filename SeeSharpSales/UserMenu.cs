﻿using System;
using System.Collections.Generic;
using System.Text;

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

        //kodebit for å bruke i main i stede for @blablabal:
        //ReadFile(UserMenu.filepath, listSalesRecords);

        //This func should be in main. Because of inheritance and because break should not be just break but a command to run the file.
        public enum FileType { none = 0, csv = 1, xml = 2, json = 3 }

        public static void CheckIfFileIsValid()
        {
            var types = Enum.GetValues(typeof(FileType)) as FileType[];
           
            foreach (var type in types)
            {
                if (filepath.EndsWith(type.ToString()))
                {
                    break;
                }
            }

            Console.WriteLine("Invalid filename");
        }
       

        public static void DisplayMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($" Menu for: {filepath}   ");
            Console.WriteLine("-------------------------------------------");

            Console.ResetColor();

            Console.WriteLine("\nTheese are your options:");

            Console.WriteLine("\n Press 1 to print report");

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

        public static void RunMenuOption(int selectedOption)
        {


            switch (selectedOption)
            {

                case 1: //print report
                    FirstOptionForTest();
                    break;

                case 2:
                    TotalSalesInDifferentRegions();
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
                Console.WriteLine("Det Jeanette driver med? ");
            }

            static void TotalSalesInDifferentRegions()
            {
                //ny menylinje med nye valg etterhvert
                Console.Clear();
                Console.WriteLine($"Det Raul lager");
            }
            
        }
    }
}
