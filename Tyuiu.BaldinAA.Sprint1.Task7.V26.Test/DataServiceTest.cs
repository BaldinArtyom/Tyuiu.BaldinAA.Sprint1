using Tyuiu.BaldinAA.Sprint1.Task7.V26.Lib;
namespace Tyuiu.BaldinAA.Sprint1.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds  = new DataService();
            double x = 0;
            double y = 1;
            double wait = 0.8529412;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}