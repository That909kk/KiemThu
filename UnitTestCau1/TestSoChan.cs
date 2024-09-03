using Cau1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestCau1
{
    [TestClass]
    public class TestSoChan
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data\\data.csv", "data#csv", DataAccessMethod.Sequential)]
        public void TestData1()
        {
            SoChan soChan = new SoChan();

            string arrStr = TestContext.DataRow["Array"].ToString();
            int[] a = string.IsNullOrEmpty(arrStr) ? new int[] { } : Array.ConvertAll(arrStr.Split(','), int.Parse);
            int b = Convert.ToInt32(TestContext.DataRow["Expected"]);

            int result = soChan.FindFirstEven(a);
            Assert.AreEqual(b, result);

        }
    }
}
