using System;
using System.Globalization;
using System.IO;
using CsvHelper;

namespace SeeSharpSales
{
    class Program 
    {
        static void Main(string[] args)
        {
            UserMenu.ChooseFileToAnalyse();
            
            UserMenu.CheckIfFileIsValid();


            //string filepath = @"c:/temp/salesRecords.csv"; denne skal tastes inn av bruker

            bool exit = false;
            do
            {
                UserMenu.DisplayMenu();
                int selectionOption = UserMenu.GetUserInput();
                RunMenuOption(selectionOption);
                UserMenu.ExitOrRunNew();

            } while (!exit);
            

            ReadFile(UserMenu.filepath); 

            
            
            Console.WriteLine($"Rauls baby TotalSold = {SalesRecordsList.TotalSold()} ");
            Console.WriteLine($"Total sales Asia: {SalesRecordsList.TotalSoldPerRegion("Asia")}");
            Console.WriteLine($"Total sales Europe: {SalesRecordsList.TotalSoldPerRegion("Europe")}");
            Console.WriteLine($"Total sales Sub-Saharan Africa: {SalesRecordsList.TotalSoldPerRegion("Sub-Saharan Africa")}");
            Console.WriteLine($"Rauls baby TotalProfit = {SalesRecordsList.TotalProfit():c} ");
   
        }

        public static void RunMenuOption(int selectedOption)
        {


            switch (selectedOption)
            {

                case 1:
                    Console.Clear();
                    WriteJsonFile("", SalesRecordsList);
                    Console.WriteLine("\nStored as json in C.\n");
                    break;

                case 2:
                    TotalSalesInDifferentRegions();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("You choose 3");
                    break;


                default:
                    UserMenu.DisplayMenu();
                    break;
            }


            static void TotalSalesInDifferentRegions()
            {
                //ny menylinje med nye valg etterhvert
                Console.Clear();
                Console.WriteLine($"Det Raul lager");
            }


        }

        private static readonly SalesRecordsList SalesRecordsList = new SalesRecordsList();

      

        private static void ReadFile(string filepath)
        {
            bool firstLine = true;
            string line;

            try
            {
                StreamReader file = new StreamReader($"{filepath}");
                while ((line = file.ReadLine()) != null)
                {
                    if (firstLine)
                    {
                        firstLine = false;
                    }
                    else
                    {
                        makeSalesRecord(line);
                    }

                }
                file.Close();
            }
            catch
            {
                Console.WriteLine("KRISE! Noe feiler, slå av og lat som ingenting ;-)");  
            }
        }
        
        static void makeSalesRecord(string line) 
        {
            SalesRecord salesRecord = new SalesRecord();

            string[] subs = SplitLine(line);

            salesRecord.Region = subs[0];
            salesRecord.Country = subs[1];
            salesRecord.ItemType = subs[2];
            salesRecord.SalesChannel = subs[3];
            salesRecord.OrderPriority = subs[4];
            salesRecord.OrderDate = subs[5];
            salesRecord.OrderID = Convert.ToInt32(subs[6]);
            salesRecord.ShipDate = subs[7];
            salesRecord.UnitsSold = Convert.ToInt32(subs[8]);
            salesRecord.UnitPrice = Convert.ToDouble(subs[9].Replace(".",","));
            salesRecord.UnitCost = Convert.ToDouble(subs[10].Replace(".", ","));
            salesRecord.TotalRevenue = Convert.ToDouble(subs[11].Replace(".", ","));
            salesRecord.TotalCost = Convert.ToDouble(subs[12].Replace(".", ","));
            salesRecord.TotalProfit = Convert.ToDouble(subs[13].Replace(".", ","));

            SalesRecordsList.SalesRecords.Add(salesRecord);
        }

        static string[] SplitLine(string line)
        {
            string[] subs = line.Split(',');
            return subs;   
        }

        private static void WriteJsonFile(string path, SalesRecordsList srListToConvert)
        {
            if (path == "")
                path = @"C:\temp\json.txt";

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.Write(srListToConvert.GetJsonString());
            }

        }

        static void ReadFileRaul(string filepath)
        {
            using var streamReader = new StreamReader($"{filepath}");
            using var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);
            
            bool firstRun = true;

            while (csvReader.Read())
            {
                if (firstRun)
                {
                    firstRun = false;
                }
                else
                {
                    SalesRecord salesRecord = new SalesRecord();
                    for (int i = 0; csvReader.TryGetField(i, out string value); i++)
                    {
                        value = value.Replace('.', ',');
                        //Console.WriteLine($"{value} {i}");
                        switch (i)
                        {
                            case 0:
                                salesRecord.Region = value;
                                break;
                            case 1:
                                salesRecord.Country = value;
                                break;
                            case 2:
                                salesRecord.ItemType = value;
                                break;
                            case 3:
                                salesRecord.SalesChannel = value;
                                break;
                            case 4:
                                salesRecord.OrderPriority = value;
                                break;
                            case 5:
                                salesRecord.OrderDate = value;
                                break;
                            case 6:
                                salesRecord.OrderID = Convert.ToInt32(value);
                                break;
                            case 7:
                                salesRecord.ShipDate = value;
                                break;
                            case 8:
                                salesRecord.UnitsSold = Convert.ToInt32(value);
                                break;
                            case 9:
                                salesRecord.UnitPrice = Convert.ToDouble(value);
                                break;
                            case 10:
                                salesRecord.UnitCost = Convert.ToDouble(value);
                                break;
                            case 11:
                                salesRecord.TotalRevenue = Convert.ToDouble(value);
                                break;
                            case 12:
                                salesRecord.TotalCost = Convert.ToDouble(value);
                                break;
                            case 13:
                                salesRecord.TotalProfit = Convert.ToDouble(value);
                                break;
                            default:
                                break;

                        }




                    }
                    SalesRecordsList.SalesRecords.Add(salesRecord);

                    
                }

                

                
            }
        }


    }
}
