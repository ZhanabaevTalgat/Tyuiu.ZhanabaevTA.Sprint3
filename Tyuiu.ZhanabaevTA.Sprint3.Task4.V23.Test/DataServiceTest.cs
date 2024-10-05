using Tyuiu.ZhanabaevTA.Sprint3.Task4.V23.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint3.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int startValue = -5; int stopValue = 5;
            DataService ds = new DataService();
            double res = ds.Calculate(startValue, stopValue);
            Assert.AreEqual(244.656 , res);
        }
    }
}