﻿using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "C# (pronounced \"See Sharp\") is a simple, modern, object-oriented, and type-safe programming language. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers.";
        str = $"{str.Substring(str.IndexOf("object-oriented"), "object-oriented".Length)} {str.Substring(str.IndexOf("programming"), "programming".Length)} {str.Substring(str.IndexOf("C#"), "C#".Length)}";
        System.Console.WriteLine(str);
    }
}