using System;


class Line
{
    public static void PrintLine(int length)
    {
        if (length <= 0) System.Console.WriteLine();
        else
        {
            Console.WriteLine(new String('_', length));
        }
    }
}

