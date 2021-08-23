using System;

/// <summary> Vector Math Class  </summary>
public class VectorMath
{
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
}