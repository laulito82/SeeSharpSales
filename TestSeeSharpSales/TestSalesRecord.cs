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



    }
}
