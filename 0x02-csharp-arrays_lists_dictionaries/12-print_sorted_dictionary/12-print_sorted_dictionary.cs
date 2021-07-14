using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var sortedDic = myDict.OrderBy(i => i.Key);
        foreach (var item in sortedDic)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
