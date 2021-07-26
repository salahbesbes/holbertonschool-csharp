using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size == 0)
        {
            Console.WriteLine();
            return new int[0];
        }
        else if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        else
        {
            int[] newArray = new int[size];
            char sep = ' ';
            for (int i = 0; i < size; i++)
            {
                if (i == size - 1) sep = '\n';
                Console.Write($"{i}{sep}");
                newArray[i] = i;
            }

            return newArray;

        }
    }
}
