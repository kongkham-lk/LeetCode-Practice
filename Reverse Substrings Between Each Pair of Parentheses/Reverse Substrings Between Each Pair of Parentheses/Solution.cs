using System;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace Reverse_Substrings_Between_Each_Pair_of_Parentheses;

public class Solution
{
    public string ReverseParentheses(string s)
    {
        if (s.Length <= 1)
            return s;

        while (s.Contains(")"))
        {
            int foundIndexOpen = -1;
            int foundIndexClose = -1;

            bool foundSwapStr = GetBracketIndex(s, ref foundIndexOpen, ref foundIndexClose);

            if (foundSwapStr)
            {
                Swap(ref foundIndexOpen, ref foundIndexClose);
                string pre = s.Substring(0, foundIndexOpen);
                string mid = s.Substring(foundIndexOpen + 1, foundIndexClose - (foundIndexOpen + 1));
                string suf = s.Substring(foundIndexClose + 1);
                mid = ReverseParentheses(mid);
                mid = ReverseString(mid);
                s = pre + mid + suf;
            }
            else
            {
                s = s.Substring(foundIndexOpen + 1, foundIndexClose - (foundIndexOpen + 1));
                s = ReverseString(s);
            }
        }

        return s;
    }

    private string ReverseString(string s)
    {
        if (s.Length <= 1)
            return s;

        string result = "";

        foreach (char substr in s)
            result = substr + result;

        return result;
    }

    private bool GetBracketIndex(string s, ref int foundIndexOpen, ref int foundIndexClose)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i].ToString().Equals("("))
                foundIndexOpen = i;
            else if (s[i].ToString().Equals(")"))
                foundIndexClose = i;

            if (foundIndexOpen != -1 && foundIndexClose != -1)
            {
                return true;
            }
        }
        return false;
    }

    private void Swap(ref int foundIndexOpen, ref int foundIndexClose)
    {
        if (foundIndexOpen > foundIndexClose)
        {
            int temp = foundIndexOpen;
            foundIndexOpen = foundIndexClose;
            foundIndexClose = temp;
        }
    }
}

