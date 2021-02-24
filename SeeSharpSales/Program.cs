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
            Console.WriteLine("Welcome to");
            Console.WriteLine("project");
            Console.WriteLine(" SSSS EEE  EEE   SSSS  H   H   A    RRR    PPP");
            Console.WriteLine("S     E    E    S      H   H  A  A  R  R   P   P");
            Console.WriteLine(" SSS  EE   EE    SSS   HHHHH  AAAA  RRR    PPP");
            Console.WriteLine("    S E    E        S  H   H  A  A  R  R   P");
            Console.WriteLine("SSSS  EEE  EEE  SSSS   H   H  A  A  R   R  P");
            Console.WriteLine("project See Sharp Sales");
            Console.WriteLine("push ENTER to continue...");
            
            
            
            
            string region = Console.ReadLine();
      
            string filepath = @"c:/temp/salesRecords.csv"; //denne skal tastes inn av bruker

            ReadFile(filepath); // LA DENNE STÅ - meny kommer før denne :)

            

            Console.WriteLine($"Rauls baby TotalSold = {SalesRecordsList.TotalSold()} ");
            Console.WriteLine($"Total sales Asia: {SalesRecordsList.TotalSoldPerRegion("Asia")}");
            Console.WriteLine($"Total sales Europe: {SalesRecordsList.TotalSoldPerRegion("Europe")}");
            Console.WriteLine($"Total sales Sub-Saharan Africa: {SalesRecordsList.TotalSoldPerRegion("Sub-Saharan Africa")}");
            Console.WriteLine($"Rauls baby TotalProfit = {SalesRecordsList.TotalProfit():c} ");

            /*
               int countFound = ListRegion(SaleRecList, "Europe"); //Skal seff ikke være hardkodet 
               Console.WriteLine($"Europe was found in {countFound} rows");

            */
            //int countSoldRegion = TotalSoldPerRegion(SaleRecList, "Europe"); //Raul: denne luringen skal vise deg solgt per region - men vi må få en variabel for region.
            //Console.WriteLine($"We have sold a totalt of {countSoldRegion} units in Europe");

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

        private void WriteFile(string path)
        {
            if (path == "")
                path = @"C:\json.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {

                }
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                
            }
        }

        /*
        private string BuildJSON()
        {
            SalesRecordsList.
        }
        */

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
