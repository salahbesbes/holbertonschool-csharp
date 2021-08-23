using System;

/// <summary> matrix math </summary>
class MatrixMath
{
    /// <summary> multiply scalar  </summary>
    /// <param name="matrix">matrix </param>
    /// <param name="scalar"> scalar </param>
    /// <returns> new matrix </returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if ((matrix.GetLength(0) == 3 || matrix.GetLength(0) == 2)
            && matrix.GetLength(0) == matrix.GetLength(1))
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] *= scalar;
                }
            }


            return matrix;
        }
        return new double[,] { { -1 } };
    }
}
