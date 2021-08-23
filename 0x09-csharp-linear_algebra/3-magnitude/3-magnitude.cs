using System;

/// <summary> Vector Math Class  </summary>
public class VectorMath
{
    /// <summary> calculate te length of the vector   </summary>
    /// <param name="vector"> array contain the coordoate of the 2D/3D vector   </param>
    /// <returns> length of the vector </returns>
    public static double Magnitude(double[] vector)
    {
        double res = 0;

        if (vector.Length != 2 && vector.Length != 3)
            return -1;


        foreach (var point in vector)
        {
            res += Math.Pow(point, 2);
        }

        return Math.Round(Math.Sqrt(res), 2);
    }
}