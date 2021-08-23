using System;

/// <summary> math matrix  </summary>
public class MatrixMath
{
    /// <summary> add 2 matrix </summary>
    /// <param name="matrix1">matrix 1</param>
    /// <param name="matrix2">matrix 2</param>
    /// <returns> matrix </returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {

        double[,] error = new double[1, 1] { { -1 } };

        if (matrix1.GetLength(0) != matrix2.GetLength(0))
            return error;
        if (matrix1.GetLength(1) != matrix2.GetLength(1))
            return error;
        if (matrix1.GetLength(1) != 2 && matrix1.GetLength(1) != 3)
            return error;
        if (matrix2.GetLength(1) != 2 && matrix2.GetLength(1) != 3)
            return error;

        double[,] res = new double[matrix1.GetLength(0), matrix1.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                res[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return res;

    }
}