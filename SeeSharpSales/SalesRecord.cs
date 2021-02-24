using System;
using System.Linq;

namespace SeeSharpSales
{
    #region enums
    
    public enum SalesChannel
    {
        Online, Offline
    }

    public enum OrderPriority
    {
        C, H, L, M
    }
    
    #endregion


    public class SalesRecord
    {


        public string Region { get; set; }
        public string Country { get; set; }
        public string ItemType { get; set; }
        public string SalesChannel { get; set; }
        public string OrderPriority { get; set; }
        public string OrderDate { get; set; }
        public int OrderID { get; set; }
        public string ShipDate { get; set; }
        public int UnitsSold { get; set; }
        public double UnitPrice { get; set; }
        public double UnitCost { get; set; }
        public double TotalRevenue { get; set; }
        public double TotalCost { get; set; }
        public double TotalProfit { get; set; }

        private const double SALES_TAX_RATE = 0.30;

        public SalesRecord()
        {

        }

        public bool isRegion(string regionInn)
        {
            if (Region == regionInn)
                return true;

            return false;
        }

        public bool isCountry(string countryInn)
        {
            if (Country == countryInn)
                return true;

            return false;
        }

        public bool isOrderID(int orderIDInn)
        {
            if (OrderID == orderIDInn)
                return true;

            return false;
        }

        public double GetSalesTax()
        {
            return UnitPrice * SALES_TAX_RATE;
        }

        public override string ToString()
        {
            return $"{Region}, country: {Country}, price: {UnitPrice:c}, units sold: {UnitsSold}, total profit: {TotalProfit}";
        }

        
        public void TotalSold(int numberOfSoldItems)
        {
            UnitsSold += numberOfSoldItems;
            //https://stackoverflow.com/questions/2419343/how-to-sum-up-an-array-of-integers-in-c-sharp
        }

        /*
        public int totalUnitsSold(int totalSales)
        {
            //return totalSales = UnitsSold.Sum();
            foreach(totalSales in UnitsSold)
            {
                sum += totalS;
            }
        }
        
        foreach (var sold in  )

        {
        var numbers = new List<int> { 2, 3, 4, 5, 6 };

        int sum = 0;

        sum = numbers.Sum();
            Console.WriteLine(sum);
        }
        */

    }
}
