﻿using System;
using System.Collections.Generic;


class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        var myLinkedList = new LinkedList<int>();
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(i);
            myLinkedList.AddFirst(i);
        }
        return myLinkedList;
    }
}
