using System;
using System.Collections.Generic;
class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        var res = new List<int>();

        for (int i = 0; i < listLength; i++)
        {
            int div = 0;
            try
            {
                div = list1[i] / list2[i];
                res.Add(div);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                res.Add(0);
            }
            catch (Exception)
            {
                Console.WriteLine("Out of range");
            }
        }
        return res;
    }
}
