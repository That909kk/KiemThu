using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestCanBac3
{
    [TestClass]
    public class UnitTestBai2
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(1, 1)]
        [DataRow(8, 2)]
        [DataRow(27, 3)]
        [DataRow(-1, -1)]
        [DataRow(-8, -2)]
        [DataRow(-27, -3)]
        [DataRow(0.001f, 0.1f)]
        [DataRow(-0.001f, -0.1f)]
      //  [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data\\data.csv", "data#csv", DataAccessMethod.Sequential)]
        //Data Csv
       // public void TestData()
       // {
       //     Cau2.CanBac3 canBac3 = new Cau2.CanBac3();
        //    float a = float.Parse(TestContext.DataRow["a"].ToString());
       //     float b = float.Parse(TestContext.DataRow["b"].ToString());
      //      float result = canBac3.sqrt3(a);
     //       Assert.AreEqual(b, result);

     //   }
        //Test case
        public void TestSqrt3(float input, float expected)
        {
            Cau2 .CanBac3 canBac3 = new Cau2.CanBac3();
            float result = canBac3.sqrt3(input);
            Assert.AreEqual(expected, result);
        }
    }
}
