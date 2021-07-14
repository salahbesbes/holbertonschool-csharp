using System;
using System.Linq;
class Array
{
    public static void Reverse(int[] array)
    {
        char sep = ' ';
        array.Reverse();
        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1) sep = '\n';
            Console.Write($"{array[i]}{sep}");
        }
    }
}
