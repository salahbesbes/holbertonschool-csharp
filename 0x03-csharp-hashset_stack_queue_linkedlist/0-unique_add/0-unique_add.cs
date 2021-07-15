using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        var hashSet = new HashSet<int>(myList);
        int sum = 0;


        foreach (int item in hashSet)
        {
            sum += item;
        }
        return sum;
    }
}
