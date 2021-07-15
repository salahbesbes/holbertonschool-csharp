using System;
using System.Collections.Generic;
using System.Collections;


class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        var result = new List<int>() { };

        foreach (int item1 in list1)
        {
            if (list2.Contains(item1)) result.Add(item1);
        }
        result.Sort();
        return result;

    }
}
