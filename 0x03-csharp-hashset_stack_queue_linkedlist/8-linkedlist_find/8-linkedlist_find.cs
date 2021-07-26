using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        try
        {

            int index = myLList.Select((item, inx) => new { item, inx })
                       .First(x => x.item == value).inx;

            return index;
        }
        catch (System.Exception)
        {
            return -1;
        }
    }
}
