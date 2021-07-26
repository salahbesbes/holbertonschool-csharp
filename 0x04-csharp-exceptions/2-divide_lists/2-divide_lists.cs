using System;
using System.Collections.Generic;
class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        var res = new List<int>();

        for (int i = 0; i < listLength; i++)
        {
            try
            {
                int el1 = list1[i];
                int el2 = list2[i];
                try
                {
                    int div = el1 / el2;
                    res.Add(div);
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Cannot divide by zero");
                    res.Add(0);
                }

            }
            catch (System.Exception)
            {
                Console.WriteLine("Out of range");
                break;
            }


        }
        return res;
    }
}
