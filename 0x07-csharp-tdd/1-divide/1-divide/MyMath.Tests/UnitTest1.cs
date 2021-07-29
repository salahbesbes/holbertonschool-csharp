using NUnit.Framework;

namespace MyMath.Tests
{

    [TestFixture]
    public class Tests
    {
        int[,] input1 = new int[,] { { 2, 2 }, { 4, 4 } };

        [Test]
        [TestCase(null, 2)]
        public void testMatrixIsNull(int[,] matrix, int num)
        {
            int[,] res = Matrix.Divide(matrix, num);
            Assert.AreEqual(null, res);

        }
    }
}