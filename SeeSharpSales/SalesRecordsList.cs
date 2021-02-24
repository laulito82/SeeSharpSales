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

        
    }
}
