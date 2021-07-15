using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        var result = new List<int>(list1);

        foreach (int item2 in list2)
        {
            if (result.Contains(item2) == false) result.Add(item2);
            else result.Remove(item2);
        }
        result.Sort();
        return result;

    }
}
