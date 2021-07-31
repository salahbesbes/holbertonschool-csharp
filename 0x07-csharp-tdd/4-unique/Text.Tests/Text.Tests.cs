using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void testReturns_Negative_1()
        {
            Assert.AreEqual(Text.Str.UniqueChar(""), -1);
            Assert.AreEqual(Text.Str.UniqueChar(null), -1);
            Assert.AreEqual(Text.Str.UniqueChar("aabbccdd"), -1);

        }

        [Test]
        public void testReturns_0()
        {
            Assert.AreEqual(Text.Str.UniqueChar("abcd"), 0);
            Assert.AreEqual(Text.Str.UniqueChar("v"), 0);
        }


        [Test]
        public void check_Last_Char()
        {
            Assert.AreEqual(7, Text.Str.UniqueChar("aabcccbd"));
            Assert.AreEqual(7, Text.Str.UniqueChar("acabccbd"));
        }
    }
}