using Tyuiu.ZhanabaevTA.Sprint3.Task1.V7.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint3.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 1;
            int start = 2; int end = 5;

            DataService ds = new DataService();
            var res = ds.GetMultiplySeries(a, start, end);
            Assert.AreEqual(13.529, res);
        }
    }
}