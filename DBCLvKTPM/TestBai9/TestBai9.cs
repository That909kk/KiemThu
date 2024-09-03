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
    internal class TestBai9
    {
        private Bai9.Bai9 bai9;

        [SetUp]
        public void Setup()
        {
            bai9 = new Bai9.Bai9();
        }
        [Test]
        public void Test() {
            Assert.That(bai9.HuyChuoi("HelloWorld", 5, 5), Is.EqualTo("Hello"));
        
        }
        [Test]
        public void Test1() {
            Assert.That(bai9.HuyChuoi("HelloWorld", 2, 3), Is.EqualTo("HelWorld"));
        }
        [Test]
        public void Test2() {
            Assert.That(bai9.HuyChuoi("HelloWorld", 5, 0), Is.EqualTo("World"));
        }
        [Test]
        public void Test3() {
            Assert.That(bai9.HuyChuoi("HelloWorld", 5, 20), Is.EqualTo("HelloWorld"));
        }
        [Test]
        public void Test4() {
            Assert.That(bai9.HuyChuoi("HelloWorld", 5, -1), Is.EqualTo("HelloWorld"));
        }
        [Test]
        public void Test5() {
            Assert.That(bai9.HuyChuoi("HelloWorld", -5, 5), Is.EqualTo("HelloWorld"));
        }
        [Test]
        public void Test6() {
            Assert.That(bai9.HuyChuoi("HelloWorld", 0, 0), Is.EqualTo("HelloWorld"));
        }

        [Test]
        public void Test7() {
            Assert.That(bai9.HuyChuoi("HelloWorld", 0, 5), Is.EqualTo("World"));
        }


    }
}
