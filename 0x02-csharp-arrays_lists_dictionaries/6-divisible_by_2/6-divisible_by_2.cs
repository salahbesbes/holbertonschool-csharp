using System;

class List
{
    public static System.Collections.Generic.List<bool> DivisibleBy2(System.Collections.Generic.List<int> myList)
    {
        var boolenList = new System.Collections.Generic.List<bool>();
        foreach (int i in myList)
        {
            boolenList.Add(i % 2 == 0);
        }
        return boolenList;
    }
}
