using System;
using System.Linq;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        try
        {
            int value = myLList.Select((item, inx) => new { item, inx })
              .First(el => el.inx == index).item;

            myLList.Remove(value);
        }
        catch (System.Exception)
        { }


    }
}
