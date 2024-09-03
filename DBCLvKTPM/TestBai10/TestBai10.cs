using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Bai10;

namespace TestBai10
{
    [TestFixture]
    internal class TestBai10
    {
        [Test]
        public void Largest_ArrayWithMultipleElements_ReturnsMaximum()
        {
            Bai10.Bai10 bai10 = new Bai10.Bai10();
            int[] array = { 1, 2, 3, 4, 5 };
            int result = bai10.Largest(array);
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void Largest_ArrayWithOneElement_ReturnsElement()
        {
            Bai10.Bai10 bai10 = new Bai10.Bai10();
            int[] array = { 1 };
            int result = bai10.Largest(array);
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void Largest_ArrayWithTwoElements_ReturnsMaximum()
        {
            Bai10.Bai10 bai10 = new Bai10.Bai10();
            int[] array = { 1, 2 };
            int result = bai10.Largest(array);
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Largest_ArrayWithMultipleElements_ReturnsMaximum1()
        {
            Bai10.Bai10 bai10 = new Bai10.Bai10();
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int result = bai10.Largest(array);
            Assert.That(result, Is.EqualTo(9));
        }
        [Test]
        public void Largest_ArrayWithNoElements_ReturnsMaximum2()
        {
            Bai10.Bai10 bai10 = new Bai10.Bai10();
            int[] array = { };
            int result = bai10.Largest(array);
            Assert.That(result, Is.EqualTo(0));
           
        }
    }
}
