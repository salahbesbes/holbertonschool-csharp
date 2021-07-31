using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        [TestCase("")]
        [TestCase(null)]

        public void TestsReturn_0(string input)
        {
            int expectd = 0;
            int res = Str.CamelCase(input);
            Assert.AreEqual(expectd, res);
        }

        [Test]
        [TestCase("salahBesBes")]
        public void TestsReturn_3(string input)
        {
            int expectd = 3;
            int res = Str.CamelCase(input);
            Assert.AreEqual(expectd, res);
        }
    }
}