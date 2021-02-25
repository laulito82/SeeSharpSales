using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeeSharpSales
{
    public class SalesRecordsList
    {
        public List<SalesRecord> SalesRecords { get; set; }

        public SalesRecordsList()
        {
            SalesRecords = new List<SalesRecord>();
        }

        public string GetJsonString()
        {
            return JsonConvert.SerializeObject(SalesRecords.ToArray());
        }

        public List<SalesRecord> SerchForCountryAndOptionalItemType(string country, string itemType)
        {
            List<SalesRecord> searchResults = new List<SalesRecord>();

            bool itemTypeInInput = true;

            if ( itemType == "")
                itemTypeInInput = false;

            foreach (SalesRecord sr in SalesRecords)
            {
                if (itemTypeInInput == true)
                {
                    if (sr.Country.ToUpper() == country.ToUpper() && sr.ItemType.ToUpper() == itemType.ToUpper())
                            searchResults.Add(sr);
                }
                else
                {
                    if (sr.Country.ToUpper() == country.ToUpper())
                        searchResults.Add(sr);
                }
            }

            return searchResults;
        }


        public int CountThisRegion(string region)
        {
            int counter = 0;
            foreach (SalesRecord sr in SalesRecords)
            {
                if (sr.Region.ToUpper() == region.ToUpper())
                    counter++;
            }
            return counter;
        }

        public int TotalSold()
        {
            int sumSales = 0;
            foreach (SalesRecord sr in SalesRecords)
            {
                if (sr.isUnitsSold())
                {
                    sumSales += sr.UnitsSold;
                }
            }
            return sumSales;

        }

        public int TotalSoldPerRegion(string region)
        {
            int sumSales = 0;
            foreach (SalesRecord sr in SalesRecords)
            {
                if (sr.isRegion(region))
                {
                    sumSales += sr.UnitsSold;
                    //Console.WriteLine($"{sr.UnitsSold} accumulated to {sumSales} for {region}"); // HER klarer den å hente string region, men ikke oppe i main. Fixable?
                }
            }
            return sumSales;
        }

        public double TotalProfit()
        {
            double sumProfit = 0;
            foreach (SalesRecord sr in SalesRecords)
            {
                if (sr.isTotalProfit())
                {
                    sumProfit += sr.TotalProfit;
                }
            }
            return sumProfit;
        }

        private int ListRegion(string region)
        {
            int countRegion = 0;
            foreach (SalesRecord sr in SalesRecords)
            {
                if (sr.isRegion(region))
                {
                    countRegion++;
                    Console.WriteLine($"{sr.Region} {sr.OrderID}");
                }
            }
            return countRegion;
        }

        public static void GlobalSalesList()
        {
            List<SalesRecord> SalesRecords = new List<SalesRecord>();
            //SalesRecords.Add(new SalesRecord());

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("OrderID:\tOrdered:\tto:\tShipped:\tPriority:\tCategory");
            Console.WriteLine("-------------------------------------------------------");
            foreach (SalesRecord sr in SalesRecords)
            {
                Console.WriteLine(sr.SalesDetails());
            }
            Console.WriteLine("-------------------------------------------------------");
        }



        //public int RegionList(string region)
        //{
        //    int countRegion = 0;
        //    int sumSales = 0;
        //    foreach (SalesRecord sr in SalesRecords)
        //    {
        //        sumSales += sr.UnitsSold;
        //        countRegion++;
        //        Console.WriteLine($"Total sales for {sr.Region}: {sr.UnitsSold}");

        //    }
        //    Console.WriteLine($"Total sales for {region}: {countRegion}");
        //    Console.WriteLine($"Total units sold in {region}: {sumSales}");
        //}
        
    }
}
