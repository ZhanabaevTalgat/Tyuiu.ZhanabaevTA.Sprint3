using Tyuiu.ZhanabaevTA.Sprint3.Task3.V11.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint3.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string value = "qpddd.q";

            DataService ds  = new DataService();
            string res = ds.ReplaceCharOnNum(value, 'q', '7');
            Assert.AreEqual("7pddd.7", res);
        }
    }
}