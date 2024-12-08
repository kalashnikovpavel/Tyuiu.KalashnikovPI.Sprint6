using Tyuiu.KalashnikovPI.Sprint6.Task1.V3.Lib;
namespace Tyuiu.KalashnikovPI.Sprint6.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int v = -5;
            int z = 5;
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(v, z);

        }
    }
}