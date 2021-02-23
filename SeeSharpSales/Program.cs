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
            Console.WriteLine("Welcome to project See Sharp Sales");

            string filepath = @"c:/temp/SalesRecords.csv";

            using (var streamReader = new StreamReader($"{filepath}"))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    //var records = csvReader.GetRecords<dynamic>().ToList(); 
                    string value;
                    //string[] Documents = System.IO.Directory.GetFiles("../../Files/SalesRecords.csv");

                    while (csvReader.Read())
                    {
                        for (int i = 0; csvReader.TryGetField(i, out value); i++)
                        {
                            Console.WriteLine($"{value}");
                        }

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
