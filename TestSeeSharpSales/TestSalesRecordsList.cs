using System;
using Xunit;
using SeeSharpSales;
using System.Collections.Generic;

namespace TestSeeSharpSales
{
    public class TestSalesRecordsList
    {
        SalesRecordsList list;
        SalesRecord record;

        public TestSalesRecordsList()
        {
            list = new SalesRecordsList();
            record = new SalesRecord();
            list.SalesRecords.Add(record);

        }

        [Fact]
        public void CountThisRegionTest()
        {
            //SalesRecord en = new SalesRecord();
            //en.Region = "Asia";
            //list.SalesRecords.Add(en);

            //SalesRecord to = new SalesRecord();
            //to.Region = "Europa";
            //list.SalesRecords.Add(to);

            //SalesRecord tre = new SalesRecord();
            //tre.Region = "Asia";
            //list.SalesRecords.Add(tre);

            //Assert.Equal(2, list.CountThisRegion("ASIA"));

            ////List<string> region = new List<string> { "Asia", "Europe", "asia" };
            ////String actual = fixture.CountThisRegion("Asia");
            ////String expected = list.CountThisRegion("ASIA");
            ////Assert.Equal(actual, expected);
        }












    }
}
