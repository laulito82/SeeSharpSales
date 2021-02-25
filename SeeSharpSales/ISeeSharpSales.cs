using System;
using System.Collections.Generic;
using System.Text;


namespace SeeSharpSales
{
    public interface ISeeSharpSales 
    {
        string Region { get; set; }
        string Country { get; set; }
        string ItemType { get; set; }
        string SalesChannel { get; set; }
        string OrderPriority { get; set; }
        string OrderDate { get; set; }
        int OrderID { get; set; }
        string ShipDate { get; set; }
        int UnitsSold { get; set; }
        double UnitPrice { get; set; }
        double UnitCost { get; set; }
        double TotalRevenue { get; set; }
        double TotalCost { get; set; }
        double TotalProfit { get; set; }
    }
}


