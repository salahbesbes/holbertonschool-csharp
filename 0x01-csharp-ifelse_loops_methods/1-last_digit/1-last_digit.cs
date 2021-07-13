using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int last_dig = number % 10;
        if (last_dig > 5)
        {
            System.Console.WriteLine($"Last digit of {number} is {last_dig} and is greater than 5");
        }
        else if (last_dig < 6 && last_dig != 0)
        {
            System.Console.WriteLine($"Last digit of {number} is {last_dig} and is less than 6 and not 0");
        }
        else
        {
            System.Console.WriteLine($"Last digit of {number} is {last_dig} and is 0");
        }
    }
}