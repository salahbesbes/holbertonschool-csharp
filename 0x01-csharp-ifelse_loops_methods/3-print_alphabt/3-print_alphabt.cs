using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int e = 'a'; e <= 'z'; e++)
            {
                if (e != 'q' && e != 'e')
                {
                    System.Console.Write((char)e);
                }
            }
        }
    }
}
