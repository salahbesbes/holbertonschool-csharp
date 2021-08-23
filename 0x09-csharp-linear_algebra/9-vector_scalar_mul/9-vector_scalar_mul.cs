using System;

/// <summary> Vector Math Class  </summary>
public class VectorMath
{
    /// <summary> calculate the multiplication of a vector </summary>
    /// <param name="vector">vector</param>
    /// <param name="scalar">multiple</param>
    /// <returns> new vector </returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] error = new double[1] { -1 };
        if (vector.Length != 2 && vector.Length != 3)
            return error;


        for (int i = 0; i < vector.Length; i++)
        {
            vector[i] = Math.Round(vector[i] * scalar, 2);
        }

        return vector;
    }
}
