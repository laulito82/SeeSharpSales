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
            list.SalesRecords.Add( new SalesRecord("Asia", "Malaysia", "Snacks", "Offline", "M", "10 / 6 / 2012", 175033080, "11 / 5 / 2012", 5033, 152.58, 97.44, 767935.14, 490415.52, 277519.62));
            list.SalesRecords.Add(new SalesRecord("Asia", "Fiji", "Office Supplies", "Offline", "L", "3 / 10 / 2012",276595246, "3 / 15 / 2012",9535,651.21,524.96,6209287.35,5005493.60,1203793.75));
            list.SalesRecords.Add(new SalesRecord("Europe", "Italy", "Office Supplies", "Online", "M", "1 / 26 / 2011", 812295901, "2 / 13 / 2011", 5263, 651.21, 524.96, 3427318.23, 2762864.48, 664453.75));
            list.SalesRecords.Add(new SalesRecord("Asia", "Nepal", "Vegetables", "Offline", "C", "6 / 2 / 2014", 443121373, "6 / 19 / 2014", 8316, 154.06, 90.93, 1281162.96, 756173.88, 524989.08));
            list.SalesRecords.Add(new SalesRecord("Australia and Oceania", "Fiji", "Personal Care", "Offline", "H", "12 / 17 / 2016", 600370490, "1 / 25 / 2017", 1824, 81.73, 56.67, 149075.52, 103366.08, 45709.44));
            list.SalesRecords.Add(new SalesRecord("Europe", "Portugal", "Office Supplies", "Online", "L", "6 / 27 / 2014", 535654580, "7 / 29 / 2014", 949, 651.21, 524.96, 617998.29, 498187.04, 119811.25));

        }


        [Theory]
        [InlineData("Portugal", "Office Supplies", 1)]
        [InlineData("Fiji", "", 2)]
        [InlineData("Fiji", "Office Supplies", 1)]
        public void SearchForCountryAndItemTypeTest(string country, string itemType, int expected)
        {
            List<SalesRecord> resultatliste = new List<SalesRecord>();
            
            resultatliste = list.SerchForCountryAndOptionalItemType( country, itemType);

            int actual = resultatliste.Count;

            Assert.Equal(expected, actual);
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
