using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Bai9;
namespace TestBai9
{
    [TestFixture]
    public class Bai9Tests
    {
        private Bai9.Bai9 _bai9;

        [SetUp]
        public void SetUp()
        {
            _bai9 = new Bai9.Bai9();
        }

        [Test]
        [TestCaseSource(nameof(GetTestCases))]
        public void HuyChuoi_Test(string inputString, int n, int p, string expectedOutput)
        {
            // Act
            var result = _bai9.HuyChuoi(inputString, n, p);

            // Assert
            Assert.That(result, Is.EqualTo(expectedOutput));
        }

        private static IEnumerable<TestCaseData> GetTestCases()
        {
            string projectDirectory = TestContext.CurrentContext.TestDirectory;
            string relativePath = Path.Combine(projectDirectory, @"..\..\..\data\testcases.csv");
            string csvFilePath = Path.GetFullPath(relativePath);
            string[] lines = File.ReadAllLines(csvFilePath);
            foreach (var line in lines.Skip(1)) // Skip header line
            {
                var values = line.Split(',');
                var inputString = values[0];
                var n = int.Parse(values[1]);
                var p = int.Parse(values[2]);
                var expectedOutput = values[3];

                yield return new TestCaseData(inputString, n, p, expectedOutput);
            }
        }
    }
}
