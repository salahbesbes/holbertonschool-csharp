using System.Linq;
/// <summary> matrix Math </summary>
class MatrixMath
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

    /// <summary> shear the matrix by the factor S </summary>
    /// <param name="matrix"> matrix </param>
    /// <param name="direction"> direction </param>
    /// <param name="factor"> factor s </param>
    /// <returns> new sheared matrix </returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] error = new double[1, 1] { { -1 } };
        double width = matrix.GetLength(1);
        double height = matrix.GetLength(0);

        if (height == 2 && width == 2 && (direction == 'x' || direction == 'y'))
        {
            double[,] res = new double[2, 2];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                double[] row = MatrixMath.GetRow(matrix, i);

                if (direction == 'x')
                {

                    res[i, 0] = row[0] +  factor * row[1];
                    res[i, 1] = row[1];
                }
                else
                {
                    res[i, 0] = row[0];
                    res[i, 1] = row[1] + factor * row[0];
                }

            }

            return res;
        }
        return error;
    }
}