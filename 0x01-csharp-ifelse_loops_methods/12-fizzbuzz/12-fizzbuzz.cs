using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string sep = " ";
            for (int nb = 0; nb <= 100; nb++)
            {
                if (nb == 100) sep = "\n";
                if (nb % 15 == 0) { Console.Write($"FizzBuzz{sep}"); }
                else if (nb % 3 == 0) { Console.Write($"Fizz{sep}"); }
                else if (nb % 5 == 0) { Console.Write($"Buzz{sep}"); }
                else Console.Write($"{nb}{sep}");
            }
        }
    }
}
