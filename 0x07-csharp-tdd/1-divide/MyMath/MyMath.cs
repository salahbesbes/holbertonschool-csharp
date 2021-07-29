using System;

namespace MyMath
{

    /// <summary>Divide matrix</summary

    public class Matrix
    {

        /// <summary> divide matrix </summary>
        /// <param name="matrix">mateix </param>
        /// <param name="num">number we want to divide with </param>
        /// <returns>modified matrix </returns>
        public static int[,] Divide(int[,] matrix, int num)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] /= num;
                }
            }
            return matrix;
        }
    }
}
