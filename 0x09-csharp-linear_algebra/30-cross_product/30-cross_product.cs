/// <summary> matrix Math </summary>
internal class MatrixMath
{
    /// <summary> create the croos product of 2 vector </summary>
    /// <param name="vector1"> vect 1 </param>
    /// <param name="vector2"> vect 2 </param>
    /// <returns> cross product vector </returns>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        double[] error = new double[1] { -1 };
        if (vector1.Length != vector2.Length)
            return error;
        if (vector1.Length != 3 || vector2.Length != 3)
            return error;

        double a1 = vector1[0];
        double a2 = vector1[1];
        double a3 = vector1[2];
        double b1 = vector2[0];
        double b2 = vector2[1];
        double b3 = vector2[2];

        double[] res = new double[3];

        res[0] = a2 * b3 - a3 * b2;
        res[1] = a3 * b1 - a1 * b3;
        res[2] = a1 * b2 - a2 * b1;

        return res;
    }
}