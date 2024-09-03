using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBai6
{
    [TestFixture]
    internal class TestBai6
    {
        [Test]
        public void Test1()
        {
            Bai6.Bai6 bai6 = new Bai6.Bai6();
            float x1, x2;
            Assert.That(bai6.SolveQuadratic(1, 0, -1, out x1, out x2), Is.EqualTo("Có 2 nghiệm phân biệt x1= 1 x2=-1"));
        }
        [Test]
        public void Test2() {
            Bai6.Bai6 bai6 = new Bai6.Bai6();
            float x1, x2;
            Assert.That(bai6.SolveQuadratic(1, 2, 3, out x1, out x2), Is.EqualTo("Vô nghiệm"));
        }

        [Test]
        public void Test3()
        {
            Bai6.Bai6 bai6 = new Bai6.Bai6();
            float x1, x2;
            Assert.That(bai6.SolveQuadratic(0, 0, 0, out x1, out x2), Is.EqualTo("Vô số nghiệm"));
        }
        [Test]
        public void Test4()
        {
            Bai6.Bai6 bai6 = new Bai6.Bai6();
            float x1, x2;
            Assert.That(bai6.SolveQuadratic(0, 0, 1, out x1, out x2), Is.EqualTo("Vô nghiệm"));
        }
        [Test]
        public void Test5()
        {
            Bai6.Bai6 bai6 = new Bai6.Bai6();
            float x1, x2;
            Assert.That(bai6.SolveQuadratic(1, 1, 1, out x1, out x2), Is.EqualTo("Vô nghiệm"));
        }
    }
}
