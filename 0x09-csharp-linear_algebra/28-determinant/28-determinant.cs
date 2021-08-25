using System;
using System.Linq;

/// <summary> matrix Math </summary>
internal class MatrixMath
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

    /// <summary> get the forword diagonal of a matrix starting from some column of line 0 </summary>
    /// <param name="matrix"> matrix </param>
    /// <param name="index"> col position from line 0 </param>
    /// <returns> array that contain the diagonal values from 3by3 matrix </returns>

    private static double[] GetForwordDiagonal(double[,] matrix, int index)
    {
        double[] diagonal = new double[3];

        diagonal[0] = matrix[0, index];
        diagonal[1] = matrix[1, index + 1];
        diagonal[2] = matrix[2, index + 2];

        return diagonal;
    }

    /// <summary> get the backward diagonal of a matrix starting from some column of line 0 </summary>
    /// <param name="matrix"> matrix </param>
    /// <param name="index"> col position from line 0 </param>
    /// <returns> array that contain the diagonal values from 3by3 matrix </returns>
    private static double[] GetBackwordDiagonal(double[,] matrix, int index)
    {
        double[] diagonal = new double[3];

        diagonal[0] = matrix[0, index];
        diagonal[1] = matrix[1, index - 1];
        diagonal[2] = matrix[2, index - 2];

        return diagonal;
    }

    /// <summary> calculate the determinant of a matrix </summary>
    /// <param name="matrix"> matrix </param>
    /// <returns> determinant </returns>
    public static double Determinant(double[,] matrix)
    {
        if ((matrix.GetLength(0) == 3 || matrix.GetLength(0) == 2)
            && matrix.GetLength(0) == matrix.GetLength(1))
        {
            double width = matrix.GetLength(1);
            double height = matrix.GetLength(0);

            if (height == 2)
            {
                return Math.Round(matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0], 2);
            }
            else
            {
                double[] col1 = GetColumn(matrix, 0);
                double[] col2 = GetColumn(matrix, 1);
                double[] diagonal;
                double sumForwordDiagonal = 0;
                double sumBackwardDiagonal = 0;
                matrix = AddColumn(matrix, col1);
                matrix = AddColumn(matrix, col2);

                PrintMatrix(matrix);
                for (int i = 0; i < width; i++)
                {
                    diagonal = GetForwordDiagonal(matrix, i);

                    double productDiagonal = 1;

                    foreach (double item in diagonal)
                    {
                        productDiagonal *= item;
                    }
                    sumForwordDiagonal += productDiagonal;
                }

                for (int j = (int)width + 1; j >= width - 1; j--)
                {
                    diagonal = GetBackwordDiagonal(matrix, j);

                    double productDiagonal = 1;
                    foreach (double item in diagonal)
                    {
                        productDiagonal *= item;
                    }
                    sumBackwardDiagonal += productDiagonal;
                }
                return Math.Round(sumForwordDiagonal - sumBackwardDiagonal, 2);
            }
        }

        return -1;
    }

    private static void PrintMatrix(double[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0}\t", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}