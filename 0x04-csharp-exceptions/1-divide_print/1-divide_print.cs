using System;
using System.Collections.Generic;

class Int
{
    public static void divide(int a, int b)
    {
        int res = 0;
        try
        {
            res = a / b;
        }
        catch (System.Exception)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine($"{a} / {b} = {res}");
        }
    }
}
