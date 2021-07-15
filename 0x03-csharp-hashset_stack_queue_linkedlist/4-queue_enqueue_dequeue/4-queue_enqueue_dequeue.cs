using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aQueue.Count}");

        if (aQueue.Count == 0) Console.WriteLine("Queue is empty");
        else Console.WriteLine($"First item: {aQueue.Peek()}");

        aQueue.Enqueue(newItem);
        Console.WriteLine($"Queue contains \"{search}\": {aQueue.Contains(search)}");


        if (aQueue.Contains(search))
        {
            string removed;
            int initLength = aQueue.Count;

            for (int i = 0; i < initLength; i++)
            {
                removed = aQueue.Dequeue();
                if (removed == search) break;

            }
        }
        return aQueue;
    }
}
