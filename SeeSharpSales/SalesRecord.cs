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
        
        
        public string Region { get; }
        public string Country { get; }
        public string ItemType { get; }
        public SalesChannel SalesChannel { get; }
        public OrderPriority OrderPriority { get; }
        public DateTime OrderDate { get; }
        public int OrderID { get; }
        public DateTime ShipDate { get; }
        public int UnitsSold { get; }
        public double UnitPrice { get; }
        public double UnitCost { get; }
        public double TotalRevenue { get; } 
        public double TotalCost { get; }
        public double TotalProfit { get; }
        

        public SalesRecord()
        {
            
        }




        










    }
}
