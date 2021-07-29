using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void simpleArray()
        {
            var input = new List<int>() { 0, 1, 2, 3 };
            int expected = 3;
            int res = Operations.Max(input);
            Assert.AreEqual(expected, res);
        }
        [Test]
        [TestCase(null)]
        public void test_returns_0(List<int>  input)
        {
            int expected = 0;
            int res = Operations.Max(input);
            Assert.AreEqual(expected, res);
        }

        [Test]
        public void test_empty_List()
        {
            int expected = 0;
            int res = Operations.Max(new List<int>());
            Assert.AreEqual(expected, res);
        }
    }
}