using System;
using System.Collections.Generic;


class Dictionary
{
    static void Main(string[] args)
    {
        int[,] twoDim = new int[5, 5];


        for (int line = 0; line < 5; line++)
        {
            for (int col = 0; col < 5; col++)
            {
                twoDim[line, col] = 0;
            }
        }
        twoDim[2, 2] = 1;

        char sep = ' ';
        for (int line = 0; line < 5; line++)
        {
            for (int col = 0; col < 5; col++)
            {
                Console.Write($"{twoDim[line, col]}{sep}");
                if ((line * 5 + col + 2) % 5 == 0) sep = '\n';
                else sep = ' ';
            }
        }

    }
    static void PrintArray(int[] array)
    {
        char sep = ' ';

        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1) sep = '\n';
            Console.Write($"{i}{sep}");
        }
    }
}
