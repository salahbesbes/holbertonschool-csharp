using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length <= 0) Console.WriteLine();
        else
        {
            for (int i = 0; i < length; i++)
            {
                System.Console.Write(new String(' ', i));
                System.Console.Write("\\\n");
            }
        }
    }
}
