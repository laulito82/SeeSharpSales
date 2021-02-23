using Xunit;
using SeeSharpSales;

namespace TestSeeSharpSales
{
    public class TestSalesRecord
    {

        SalesRecord salesRecord;

        public TestSalesRecord()
        {
            salesRecord = new SalesRecord();

        }
        
        [Fact]
        public void isRegionTrueTest()
        {
            salesRecord.Region = "Europe";
            
            Assert.True(salesRecord.isRegion("Europe"));    
        }

        [Fact]
        public void isRegionFalseTest()
        {
            salesRecord.Region = "Asia";

            Assert.False(salesRecord.isRegion("Europe"));
        }

        [Fact]
        public void isOrderIDTrueTest()
        {
            salesRecord.OrderID = 686800706;

            Assert.True(salesRecord.isOrderID(686800706));
        }

        [Fact]
        public void isOrderIDFalseTest()
        {
            salesRecord.OrderID = 686800706;

            Assert.False(salesRecord.isOrderID(686800711));
        }


    }
}
