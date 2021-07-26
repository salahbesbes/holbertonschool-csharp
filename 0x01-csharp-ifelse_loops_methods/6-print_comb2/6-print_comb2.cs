using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sep = ", ";
            for (int line = 0; line < 10; line++)
            {
                for (int nb = line + 1; nb < 10; nb++)
                {
                    if (line * 10 + nb == 89) sep = "\n";
                    System.Console.Write($"{line * 10 + nb:D2}{sep}");
                }
            }
        }
    }
}
