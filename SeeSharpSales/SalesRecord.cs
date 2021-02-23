using System;

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
        public SalesChannel SalesChannel { get; set; }
        public OrderPriority OrderPriority { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderID { get; set; }
        public DateTime ShipDate { get; set; }
        public int UnitsSold { get; set; }
        public double UnitPrice { get; set; }
        public double UnitCost { get; set; }
        public double TotalRevenue { get; set; } 
        public double TotalCost { get; set; }
        public double TotalProfit { get; set; }
        

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
        










    }
}
