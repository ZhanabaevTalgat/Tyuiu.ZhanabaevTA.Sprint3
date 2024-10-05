using Tyuiu.ZhanabaevTA.Sprint3.Task2.V27.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint3.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 14;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            Assert.AreEqual(0.69, res);
        }
    }
}