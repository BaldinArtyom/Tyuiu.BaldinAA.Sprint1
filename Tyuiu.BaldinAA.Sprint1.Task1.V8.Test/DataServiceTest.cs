using Tyuiu.BaldinAA.Sprint1.Task1.V8.Lib;
namespace Tyuiu.BaldinAA.Sprint1.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double a = 4.0;
            var res = ds.Calculate(x, a);
            Assert.AreEqual(1.57, res);

        }
    }
}