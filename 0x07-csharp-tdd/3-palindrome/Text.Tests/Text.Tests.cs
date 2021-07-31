using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("earae")]
        [TestCase("ACCCA")]
        [TestCase("Bvccvb")]
        [TestCase("A man, a plan, a canal: Panama.")]
        [TestCase("")]
        [TestCase("a")]
        public void TestCasesExpectedTrue(string input)
        {
            bool expected = true;
            bool res = Str.IsPalindrome(input);
            Assert.AreEqual(expected, res);
        }

        [Test]
        [TestCase("salah")]
        [TestCase("Salah")]
        [TestCase(null)]
        public void TestCasesExpectedFalse(string input)
        {
            bool expected = false;
            bool res = Str.IsPalindrome(input);
            Assert.AreEqual(expected, res);
        }
    }
}