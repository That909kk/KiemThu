using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Bai7;

namespace TestBai7
{
    [TestFixture]
    public class TestBai7
    {
        [Test]
        public void TestTinhTienDien()
        {
            Bai7.Bai7 bai7 = new Bai7.Bai7(100, 200);
            double tienDien= bai7.TinhTienDien(100, 200);
            Assert.That(bai7.TinhTienDien(100,200),Is.EqualTo(168630));
        }
        [Test]
        public void TestTinhTienDien1()
        {
            Bai7.Bai7 bai7 = new Bai7.Bai7(0, 50);
            double tienDien = bai7.TinhTienDien(0, 50);
            Assert.That(bai7.TinhTienDien(100, 200), Is.EqualTo(81620));
        }
    }
}
