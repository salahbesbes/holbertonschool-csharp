using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [TestCase(20, 0)]
        [TestCase(10, 10)]
        [TestCase(80, -60)]
        public void addition(int value, int valueb)
        {
            var result = Operations.Add(value, valueb);
            Assert.AreEqual(20, result);
        }
    }
}