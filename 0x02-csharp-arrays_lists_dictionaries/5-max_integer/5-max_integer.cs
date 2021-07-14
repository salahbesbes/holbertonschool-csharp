using System;

class List
{
    public static int MaxInteger(System.Collections.Generic.List<int> myList)
    {

        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }

        int MinValue = int.MinValue;
        for (int i = 0; i < myList.Count; i++)
        {
            if (myList[i] > MinValue)
            {

                MinValue = myList[i];
            }
        }

        return MinValue;
    }
}
