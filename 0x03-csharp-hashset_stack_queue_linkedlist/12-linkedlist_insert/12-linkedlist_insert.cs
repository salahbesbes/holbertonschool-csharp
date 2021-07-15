﻿using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        int value = myLList.Select((item, inx) => new { item, inx })
           .First(el => el.item > n).item;


        LinkedListNode<int> reff = myLList.Find(value);

        var newNode = new LinkedListNode<int>(n);

        myLList.AddBefore(reff, newNode);

        return newNode;

    }
}
