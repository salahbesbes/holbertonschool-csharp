﻿using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        var deletedNode = myLList.First;
        myLList.Remove(deletedNode);
        return deletedNode.Value;
    }
}
