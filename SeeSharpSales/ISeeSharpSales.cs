using System;
using System.Collections.Generic;
using System.Text;


namespace SeeSharpSales
{
    public interface ISeeSharpSales 
    {
        //Note-to-self: remember to take away notes-to-self in the end to get a crisp and clean code
        //Interface should tell all classes that wants to use it that they need all the properties and methods listed in this interface 
        // need to 
        // 1.)See if it is a file we can read: it must have a name and check if that name is one of the filenames we can read
        // 2.) See if the file contains all the properties/fields we need (Region, Country etc)  

        // After we implement the interface we could change the list items
        //(List <ourName> salesrecord = AddSampledata), we could change it to (List <IReadable> = AddSampledata) 
        //Because the method knows it will get the right info from the file 

        string Name { get; }

        void CorrectFileName();

        //2 coulmns we new in the file we want to use
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

    }
}


