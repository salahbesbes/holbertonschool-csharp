using System;
using System.Linq;
using System.Collections.Generic;


class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {

        if (myList.Count == 0) return "None";
        var orderedValue = myList.OrderBy(item => item.Value);

        return orderedValue.Last().Key;

    }
}
