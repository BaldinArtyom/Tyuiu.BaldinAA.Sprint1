using Tyuiu.BaldinAA.Sprint1.Task3.V9.Lib;
namespace Tyuiu.BaldinAA.Sprint1.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 90;
            var res = ds.ConvertMinutesToHours(x);
            Assert.AreEqual(1.5, res);

        }
    }
}