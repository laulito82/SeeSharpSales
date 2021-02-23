using Xunit;
using SeeSharpSales;

namespace TestSeeSharpSales
{
    public class TestSalesRecord
    {

        SalesRecord recordFirst;

        public TestSalesRecord()
        {
            recordFirst = new SalesRecord();

        }
        
        [Fact]
        public void ConstructorTest()
        {
            SalesRecord salesRecord = new SalesRecord();

            int actual = recordFirst.OrderID + 1;

            Assert.Equal(salesRecord.OrderID, actual);
        }
    }
}
