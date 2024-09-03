using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Bai10;

namespace TestBai10
{
    [TestFixture]
    public class Bai10Tests
    {
        private static IEnumerable<TestCaseData> TestData()
        {
            // Đọc dữ liệu từ file CSV
            string projectDirectory = TestContext.CurrentContext.TestDirectory;
            string relativePath = Path.Combine(projectDirectory, @"..\..\..\data\test.csv");
            string csvFilePath = Path.GetFullPath(relativePath);
            var lines = File.ReadAllLines(csvFilePath);

            // Bỏ qua dòng tiêu đề
            var testData = lines.Skip(1)
                .Select(line =>
                {
                    var parts = line.Split(',');

                    // Kiểm tra và loại bỏ các phần tử rỗng
                    var inputArray = parts.Where(p => !string.IsNullOrEmpty(p)).Select(int.Parse).ToArray();

                    // Đảm bảo rằng có ít nhất một phần tử trong inputArray
                    if (inputArray.Length == 0)
                    {
                        return null;
                    }

                    var expectedResult = int.Parse(parts.Last());
                    return new TestCaseData(inputArray).Returns(expectedResult);
                })
                .Where(data => data != null);

            return testData;
        }

        [TestCaseSource(nameof(TestData))]
        public int Largest_Test(int[] array)

        {
            Bai10.Bai10 bai10 = new Bai10.Bai10();
            return bai10.Largest(array);
        }
    }
}
