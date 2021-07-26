using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            string sep = ", ";
            for (int i = 0; i <= 99; i++)
            {
                if (i == 99) sep = "\n";
                System.Console.Write($"{i:D2}{sep}");
            }
        }
    }
}
