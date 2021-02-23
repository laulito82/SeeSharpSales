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
            ReadFile(filepath);



            
        }

        static void ReadFile(string filepath)
        {
            using var streamReader = new StreamReader($"{filepath}");
            using var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);

            while (csvReader.Read())
            {
                for (int i = 0; csvReader.TryGetField(i, out string value); i++)
                {
                    Console.WriteLine($"{value}");
                }

                Console.WriteLine();
            }
        }
        





    }
}
