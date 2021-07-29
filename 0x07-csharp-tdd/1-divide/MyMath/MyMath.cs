using System;
using System.Collections.Generic;

namespace MyMath
{
    public class Matrix
    {
        public static int[,] Divide(int[,] matrix, int num)
        {

            if (matrix == null) return null;
            if (num == 0)
            {

                Console.WriteLine("Num cannot be 0");
                return null;
            }

            if (num > int.MaxValue) return null;


            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    matrix[i, j] /= 2;
                }
            }

            return matrix;
        }
    }
}
