using System;
using System.Collections.Generic;
class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        var newDict = new Dictionary<string, int>();

        foreach (KeyValuePair<string, int> item in myDict)
        {
            Console.WriteLine(item.Value);
            newDict.Add(item.Key, item.Value * 2);
        }

        return newDict;
    }
}
