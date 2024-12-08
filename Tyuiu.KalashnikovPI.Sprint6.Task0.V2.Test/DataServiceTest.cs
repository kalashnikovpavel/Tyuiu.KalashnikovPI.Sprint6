using Tyuiu.KalashnikovPI.Sprint6.Task0.V2.Lib;
namespace Tyuiu.KalashnikovPI.Sprint6.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 6.425;
            Assert.AreEqual(wait, res);
        }
    }
}