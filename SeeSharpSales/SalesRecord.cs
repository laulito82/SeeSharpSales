using System;
using System.Linq;

namespace SeeSharpSales
{
   
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

        public SalesRecord(string region, 
                           string country, 
                           string itemType, 
                           string salesChannel, 
                           string orderPriority, 
                           string orderDate, 
                           int orderID, 
                           string shipDate, 
                           int unitsSold, 
                           double unitPrice, 
                           double unitCost, 
                           double totalRevenue, 
                           double totalCost, 
                           double totalProfit)
        {
            Region = region;
            Country = country;
            ItemType = itemType;
            SalesChannel = salesChannel;
            OrderPriority = orderPriority;
            OrderDate = orderDate;
            OrderID = orderID;
            ShipDate = shipDate;
            UnitsSold = unitsSold;
            UnitPrice = unitPrice;
            UnitCost = unitCost;
            TotalRevenue = totalRevenue;
            TotalCost = totalCost;
            TotalProfit = totalProfit;
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

        public bool isUnitsSold()
        {
            if (UnitsSold > 0)
                return true;

            return false;
        }

        public bool isOrderID(int orderIDInn)
        {
            if (OrderID == orderIDInn)
                return true;

            return false;
        }

        public bool isTotalProfit()
        {
            if (TotalProfit >= 0)
                return true;
            
            return false;
        }



        public double GetSalesTax()
        {
            return UnitPrice * SALES_TAX_RATE;
        }

        public override string ToString()
        {
            return $"OrderID: {OrderID} Region: {Region}, country: {Country}, price: {UnitPrice:c}, units sold: {UnitsSold}, total profit: {TotalProfit}";
        }

        public string SalesDetails() => $"{OrderID}\t {OrderDate}\t{Country}\t{ShipDate}\t{OrderPriority} \t{ItemType},  ";

        /*
        public void TotalSold(int numberOfSoldItems)
        {
            UnitsSold += numberOfSoldItems;
            //https://stackoverflow.com/questions/2419343/how-to-sum-up-an-array-of-integers-in-c-sharp
        }
        */


    }
}
