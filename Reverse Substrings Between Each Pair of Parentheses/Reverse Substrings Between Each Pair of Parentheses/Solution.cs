using System;
namespace Reverse_Substrings_Between_Each_Pair_of_Parentheses;

public class Solution
{
    public string ReverseParentheses(string s)
    {
        s = ReverseSubString(s);
        return s;
    }

    private string ReverseSubString(string s)
    {
        // ( ed(et(oc))el )
        // ed( et(oc) )el
        // et( oc )

        string pre = "";
        string mid = "";
        string suf = "";
        string result = "";
        int foundIndexClose = 0;

        int foundIndexOpen = s.IndexOf("(");
        if (foundIndexOpen != -1)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i].ToString().Equals(")"))
                {
                    foundIndexClose = i;
                    break;
                }
            }

            pre = s.Substring(0, foundIndexOpen); // ed
            mid = s.Substring(foundIndexOpen + 1, foundIndexClose - (foundIndexOpen + 1)); // et( oc )
            suf = s.Substring(foundIndexClose + 1); // el
            mid = ReverseSubString(mid); // etco
        }

        foreach (char substr in mid)
            result = substr + result; // octe

        return pre + result + suf; // edocteel
    }
}

