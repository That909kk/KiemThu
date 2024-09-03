using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Bai5;

namespace TestBai5
{
    [TestFixture]

    public class TestBai5 { 
        [Test]
        public void Test1()
        {
           
            Bai5.Bai5 bai5 = new Bai5.Bai5();
            Assert.That(bai5.Triangle(3,4,5), Is.EqualTo("Scalene"));
        }
        [Test]
        public void Test2()
        {
            Bai5.Bai5 bai5 = new Bai5.Bai5();
            Assert.That(bai5.Triangle(3, 3, 3), Is.EqualTo("Equilateral"));
        }
        [Test]
        public void Test3()
        {
            Bai5.Bai5 bai5 = new Bai5.Bai5();
            Assert.That(bai5.Triangle(3, 3, 4), Is.EqualTo("Isosceles"));
        }
        [Test]
           public void Test4()
        {
            Bai5.Bai5 bai5 = new Bai5.Bai5();
            Assert.That(bai5.Triangle(0, 0, 0), Is.EqualTo(""));
        }
        [Test]
        public void Test5()
        {
            Bai5.Bai5 bai5 = new Bai5.Bai5();
            Assert.That(bai5.Triangle(1, 2, 3), Is.EqualTo(""));
        }
       
    }
}
