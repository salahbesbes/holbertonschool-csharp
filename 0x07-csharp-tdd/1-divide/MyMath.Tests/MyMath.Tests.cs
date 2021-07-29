using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void Divide_Matrix_Not_empty()
        {
            int[,] matrix = new int[,] { { 4, 2 }, { 2, 3 }, { 3, 0 } };
            int num = 2;
            int[,] expected = new int[,] { { 2, 1 }, { 1, 1 }, { 1, 0 } };
            Assert.AreEqual(expected, Matrix.Divide(matrix, num));
        }


        [Test]
        public void Divide_NullMatrixBy_Number()
        {
            int[,] matrix = null;
            int num = 2;
            Assert.AreEqual(null, Matrix.Divide(matrix, num));
        }


        [Test]
        public void Divide_NumberEqual_To_0()
        {
            int[,] matrix = new int[,] { { 4, 2 }, { 2, 3 }, { 3, 0 } };
            int[,] expected = null;
            Assert.AreEqual(expected, Matrix.Divide(matrix, 0));
        }
    }
}