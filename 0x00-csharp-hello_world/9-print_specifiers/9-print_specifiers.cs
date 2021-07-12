using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double percent = .7553;
        double currency = 98765.4321;
        string[] cultureNames = { "en-US" };
        CultureInfo culture = new CultureInfo("en-US");
        System.Console.WriteLine($"Percent: {percent:p1} tip");
        System.Console.WriteLine(currency.ToString("C2", culture));
    }
}