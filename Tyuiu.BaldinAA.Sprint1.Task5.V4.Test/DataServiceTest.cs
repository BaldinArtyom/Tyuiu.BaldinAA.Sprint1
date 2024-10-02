using Tyuiu.BaldinAA.Sprint1.Task5.V4.Lib;
namespace Tyuiu.BaldinAA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int k = 13257;
            DataService ds = new DataService();
            int res = ds.SecondsToHours(k);

            int h = 3;
            Assert.AreEqual(h, res);
        }
    }
}