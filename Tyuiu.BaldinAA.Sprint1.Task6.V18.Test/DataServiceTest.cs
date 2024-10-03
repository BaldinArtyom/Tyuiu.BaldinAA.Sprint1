using Tyuiu.BaldinAA.Sprint1.Task6.V18.Lib;
namespace Tyuiu.BaldinAA.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            var DataService = new DataService();
            Assert.AreEqual(true, DataService.CheckNumber("123"));

        }
    }
}