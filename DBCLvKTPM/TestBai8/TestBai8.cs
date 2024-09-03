using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBai8
{
    [TestFixture]
    public class TestBai8
    {
        [Test]
        public void TestSum()
        {
            Bai8.Bai8 bai8 = new Bai8.Bai8();
            long s0 = 100;
            long s;
            Assert.That(bai8.Sum(s0, out s), Is.EqualTo(15));
        }
    }
}
