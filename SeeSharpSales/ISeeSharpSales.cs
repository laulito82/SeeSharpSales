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

        //1.file must have a name
        string Name { get; }

        //1. need a method to check if we have a file name of the type we support. We can change the name accorrding to the method written in SalesRecord
        void CorrectFileName();

        //2. coulmns we need in the file we want to use
        string Region { get; }

        string Country { get; }

        string ItemType { get; }

        SalesChannel SalesChannel { get; }

        OrderPriority OrderPriority { get; }

        DateTime OrderDate { get; }

        int OrderID { get; }

        DateTime ShipDate { get; }

        int unitsSold { get; }

        double unitPrice { get; }

        double unitCost { get; }

        double totalRevenue { get; }

        double totalCost { get; }

        double totalProfit { get; }

    }
}


