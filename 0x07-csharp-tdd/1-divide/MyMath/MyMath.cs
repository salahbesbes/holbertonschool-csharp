using System;
using System.Collections.Generic;
namespace MyMath
{
    public class Matrix
    {
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (num == 0 || matrix == null) return null;

            for (int i = 0; i< num; i++)
            {
                for(int j = 0; j < num; j++)
                {
                    matrix[i, j] /= 2;
                }
            }

            
            return matrix ;
        }

    }
}
