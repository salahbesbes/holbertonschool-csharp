using System;

class List
{
    public static System.Collections.Generic.List<int> DeleteAt(System.Collections.Generic.List<int> myList, int index)
    {
        if (index >= 0 && index < myList.Count)
        {
            myList.RemoveRange(index, 1);
        }

        return myList;
    }
}
