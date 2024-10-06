using Tyuiu.ZhanabaevTA.Sprint3.Task7.V3.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint3.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int start = -1; int end = 1;
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(start, end);
            double[] await = new double[3];

            await[0] = 2.93;
            await[1] = 2.5;
            await[2] = 0.71;

            CollectionAssert.AreEqual(await, res);
        }
    }
}