using System;
using System.Linq;
using System.Collections.Generic;


class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        var orderedValue = myList.OrderBy(item => item.Value);
        return orderedValue.Last().Key;
    }
}
