using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (myLList.Count == 0) return 0;

        try
        {

            int value = myLList.Select((item, inx) => new { item, inx })
                       .First(el => el.inx == n).item;
            return value;
        }
        catch (System.Exception)
        {
            return 0;
        }
    }
}
