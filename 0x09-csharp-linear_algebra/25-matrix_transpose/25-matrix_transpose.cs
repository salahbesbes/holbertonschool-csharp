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

    /// <summary> add colum to a matrix </summary>
    /// <param name="original"> original matrix </param>
    /// <param name="added"> row to add </param>
    /// <returns> new matrix added </returns>
    private static double[,] AddColumn(double[,] original, double[] added)
    {
        // get index of last row else -1
        int lastRow = original.GetUpperBound(0);
        // get index of last col else -1
        int lastColumn = original.GetUpperBound(1);

        if (lastRow == -1 && lastColumn == -1)
        {
            double[,] emtyMatrix = new double[added.Length, 1];
            // Add the new column.
            for (int i = 0; i < added.Length; i++)
            {
                emtyMatrix[i, 0] = added[i];
            }
            return emtyMatrix;
        }
        // Create new array.
        double[,] result = new double[lastRow + 1, lastColumn + 2];
        // Copy the array.
        for (int i = 0; i <= lastRow; i++)
        {
            for (int x = 0; x <= lastColumn; x++)
            {
                result[i, x] = original[i, x];
            }
        }
        // Add the new column.
        for (int i = 0; i < added.Length; i++)
        {
            result[i, lastColumn + 1] = added[i];
        }
        return result;
    }

    /// <summary> transpose matrix </summary>
    /// <param name="matrix"> matrix </param>
    /// <returns> new matrix transposed </returns>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] error = new double[,] { { } };

        // get index of last row else -1
        int lastRow = matrix.GetUpperBound(0);
        // get index of last col else -1
        int lastColumn = matrix.GetUpperBound(1);
        if (lastRow == -1 && lastColumn == -1)
            return new double[,] { { } };

        int width, height;
        double[,] res = new double[0, 0];

        height = matrix.GetLength(0);
        width = matrix.GetLength(1);

        for (int i = 0; i < height; i++)
        {
            double[] row = MatrixMath.GetRow(matrix, i);
            res = MatrixMath.AddColumn(res, row);
        }

        return res;
    }
}