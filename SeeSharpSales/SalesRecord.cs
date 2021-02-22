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

    class SalesRecord
    {
        string region;
        string country;
        string itemType;
        SalesChannel salesChannel;
        OrderPriority orderPriority;
        DateTime orderDate;
        int orderID;
        DateTime shipDate;
        int unitsSold;
        double unitPrice;
        double unitCost;
        double totalRevenue;
        double totalCost;
        double totalProfit;

    }
}
