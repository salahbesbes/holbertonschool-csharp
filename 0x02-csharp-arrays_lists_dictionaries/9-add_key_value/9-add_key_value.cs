using System;

class Dictionary
{
    public static System.Collections.Generic.Dictionary<string, string> AddKeyValue(System.Collections.Generic.Dictionary<string, string> myDict, string key, string value)
    {
        myDict[key] = value;
        return myDict;
    }
}
