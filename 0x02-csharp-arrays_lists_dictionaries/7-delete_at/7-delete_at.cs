using System;

class List
{
    public static System.Collections.Generic.List<int> DeleteAt(System.Collections.Generic.List<int> myList, int index)
    {
        System.Collections.Generic.List<int> sub1;
        System.Collections.Generic.List<int> sub2;

        sub1 = myList.GetRange(0, index);
        sub2 = myList.GetRange(index + 1, myList.Count - index - 1);
        myList.Clear();
        myList.AddRange(sub1);
        myList.AddRange(sub2);


        return myList;
    }
}
