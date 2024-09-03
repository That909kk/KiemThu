using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBai8
{
    internal class TestBai8_CSV
    {
        private Bai8.Bai8 _bai8;

        [SetUp]
        public void SetUp()
        {
            _bai8 = new Bai8.Bai8();
        }

        [Test]
        [TestCaseSource(nameof(GetTestCases))]
        public void Sum_Test(long s0, long expectedS, long expectedK)
        {
            // Act
            var result = _bai8.Sum(s0, out long s);

            // Assert
            Assert.That(s, Is.EqualTo(expectedS));
            Assert.That(result, Is.EqualTo(expectedK));
        }

        private static IEnumerable<TestCaseData> GetTestCases()
        {
            string projectDirectory = TestContext.CurrentContext.TestDirectory;
            string relativePath = Path.Combine(projectDirectory, @"..\..\..\data\testcases_sum.csv");
            string csvFilePath = Path.GetFullPath(relativePath);
            string[] lines = File.ReadAllLines(csvFilePath);
            foreach (var line in lines.Skip(1)) // Skip header line
            {
                var values = line.Split(',');
                var s0 = long.Parse(values[0]);
                var expectedS = long.Parse(values[1]);
                var expectedK = long.Parse(values[2]);

                yield return new TestCaseData(s0, expectedS, expectedK);
            }
        }
    }
}
