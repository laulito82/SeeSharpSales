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

        public static int keyID = 0;

        public string Region { get; }
        public string Country { get; }
        public string ItemType { get; }
        public SalesChannel SalesChannel { get; }
        public OrderPriority OrderPriority { get; }
        public DateTime OrderDate { get; }
        public int OrderID { get; }
        public DateTime ShipDate { get; }
        public int unitsSold { get; }
        public double unitPrice { get; }
        public double unitCost { get; }
        public double totalRevenue { get; } 
        public double totalCost { get; }
        public double totalProfit { get; }


        public SalesRecord()
        {
            OrderID = keyID++;
        }















}
}
