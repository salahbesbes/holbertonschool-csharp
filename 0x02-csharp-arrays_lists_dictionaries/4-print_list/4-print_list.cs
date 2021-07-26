using System;
using System.Collections.Generic;
class List
{
    public static List<int> CreatePrint(int size)
    {

        var newList = new List<int>();

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        if (size == 0)
        {
            Console.WriteLine();
            return newList;
        }

        char sep = ' ';

        for (int i = 0; i < size; i++)
        {
            if (i == size - 1) sep = '\n';
            Console.Write($"{i}{sep}");
            newList.Add(i);
        }

        return newList;
    }
}
