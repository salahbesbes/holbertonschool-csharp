using System;

class Character
{
    public static bool IsLower(char c)
    {
        if ((int)c >= 'A' && (int)c <= 'Z') return false;
        else return true;

    }
}