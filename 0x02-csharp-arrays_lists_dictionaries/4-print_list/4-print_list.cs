using System;

class List
{
    public static System.Collections.Generic.List<int> CreatePrint(int size)
    {

        var newList = new System.Collections.Generic.List<int>();
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
