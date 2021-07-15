﻿using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aQueue.Count}");

        if (aQueue.Count == 0) Console.WriteLine("Queue is empty");
        else Console.WriteLine($"First item: {aQueue.Peek()}");

        aQueue.Enqueue(newItem);
        if (aQueue.Contains(search)) Console.WriteLine($"Queue contains \"{search}\": {aQueue.Contains(search)}");


        if (aQueue.Contains(search))
        {
            string removed;

            for (int i = 0; i < aQueue.Count; i++)
            {
                removed = aQueue.Dequeue();
                if (removed == search) break;

            }
        }
        return aQueue;
    }
}
