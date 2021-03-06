using System;
using System.Linq;

/// <summary> matrix Math </summary>
internal class MatrixMath
{
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

    /// <summary> rotate matrix </summary>
    /// <param name="matrix"> matrix </param>
    /// <param name="angle"> radiant angle </param>
    /// <returns> new matrix </returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] error = new double[1, 1] { { -1 } };
        double width = matrix.GetLength(1);
        double height = matrix.GetLength(0);

        if (height == 2 && width == 2)
        {
            double[,] res = new double[2, 2];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                double[] row = MatrixMath.GetRow(matrix, i);

                res[i, 0] = Math.Round( Math.Round(row[0] * Math.Cos(angle), 2) - Math.Round( row[1] * Math.Sin(angle), 2), 2);
                res[i, 1] = Math.Round( Math.Round(row[0] * Math.Sin(angle), 2) + Math.Round( row[1] * Math.Cos(angle), 2), 2);
            }

            return res;
        }
        return error;
    }
}