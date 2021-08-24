using System;
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
    /// <summary> calculate the dot product of  2 vectors </summary>
    /// <param name="vector1"> vector 1 </param>
    /// <param name="vector2"> vector 2 </param>
    /// <returns> dot product of 2 vectors </returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {

        if (vector1.Length != vector2.Length)
            return -1;
        if (vector1.Length != 2 && vector1.Length != 3)
            return -1;
        if (vector2.Length != 2 && vector2.Length != 3)
            return -1;

        double res = 0f;

        for (int i = 0; i < vector1.Length; i++)
        {
            res += vector1[i] * vector2[i];
        }


        return res;

    }
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] error = new double[1, 1] { { -1 } };

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return error;


        double[] newXPos = new double[2];
        double[] newYPos = new double[2];


        newXPos[0] = Math.Round( Math.Cos(angle), 0);
        newXPos[1] = Math.Round( Math.Sin(angle), 0);

        newYPos[0] = - Math.Round( Math.Sin(angle), 0);
        newYPos[1] = Math.Round( Math.Cos(angle), 0);

        



        double[,] res = new double[2, 2];


        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            double[] row = MatrixMath.GetRow(matrix, i);

            res[i, 0] = row[0] * newXPos[0] + row[1] * newYPos[0];
            res[i, 1] = row[0] * newXPos[1] + row[1] * newYPos[1];

        }
        return res;



        

       
    }
}
