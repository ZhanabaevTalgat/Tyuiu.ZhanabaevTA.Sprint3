using Tyuiu.ZhanabaevTA.Sprint3.Task6.V11.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint3.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int start = 10; int end = 19;
            DataService ds = new DataService();
            int result = ds.GetSumTheDivisors(start, end);
            Assert.AreEqual(start, result);
        }
    }
}