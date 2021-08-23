using System;

/// <summary> Vector Math Class  </summary>
public class VectorMath
{
    /// <summary> calculate the sum of 2 vectors </summary>
    /// <param name="vector1">vector 1 </param>
    /// <param name="vector2">vector 2</param>
    /// <returns> new array of the sum </returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        
        double[] TowD = new double[2] { 0, 0 };
        double[] ThreeD = new double[3] { 0, 0, 0 };
        double[] error = new double[1] { -1 };



        if (vector1.Length != vector2.Length)
            return error;
        if (vector1.Length != 2 && vector1.Length != 3)
            return error;
        if (vector2.Length != 2 && vector2.Length != 3)
            return error;


        if (vector1.Length == 2 )
        {
            for (int i = 0; i < vector1.Length; i++)
            {
                TowD[i] = vector1[i] + vector2[i]; 
            }

            return TowD;
        }

        if (vector1.Length == 3)
        {
            for (int i = 0; i < vector1.Length; i++)
            {
                ThreeD[i] = vector1[i] + vector2[i];
            }

            return ThreeD;

        }

        return error;
        
    }
}

