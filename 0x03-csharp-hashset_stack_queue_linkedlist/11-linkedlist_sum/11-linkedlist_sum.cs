using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int sum;

        foreach (var node in myLList)
        {
            sum += node.Value;
        }
        return sum;
    }
}
