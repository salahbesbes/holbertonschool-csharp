using System;
using System.Linq;

/// <summary> matrix Math </summary>
class MatrixMath
{

    /// <summary> get the specific column from a matrix </summary>
    /// <param name="matrix"> matrix </param>
    /// <param name="columnNumber"> column number </param>
    /// <returns> hole column from a matrix </returns>
    public static double[] GetColumn(double[,] matrix, int columnNumber)
    {
        return Enumerable.Range(0, matrix.GetLength(0))
                .Select(x => matrix[x, columnNumber])
                .ToArray();
    }
    /// <summary> get the specific row from a matrix </summary>
    /// <param name="matrix"> matrix </param>
    /// <param name="rowNumber"> row number </param>
    /// <returns> hole row from a matrix </returns>

    public static double[] GetRow(double[,] matrix, int rowNumber)
    {
        return Enumerable.Range(0, matrix.GetLength(1))
                .Select(x => matrix[rowNumber, x])
                .ToArray();
    }
    /// <summary> calculate the dot product of  2 vectors </summary>
    /// <param name="vector1"> vector 1 </param>
    /// <param name="vector2"> vector 2 </param>
    /// <returns> dot product of 2 vectors </returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {

        if (vector1.Length != vector2.Length)
            return -1;
        

        double res = 0f;

        for (int i = 0; i < vector1.Length; i++)
        {
            res += vector1[i] * vector2[i];
        }


        return res;

    }
    /// <summary> multiply 2 matrix </summary>
    /// <param name="matrix1">matrix 1</param>
    /// <param name="matrix2"> matrix 2</param>
    /// <returns> new matrix the product of both matrix </returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {

        double[,] error = new double[1, 1] { { -1 } };

        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return error;

        double[,] res = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            double[] row = MatrixMath.GetRow(matrix1, i);

            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                double[] col = MatrixMath.GetColumn(matrix2, j);

                res[i, j] = MatrixMath.DotProduct(row, col);

            }
        }
        return res;
    }
}
