using System;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace Reverse_Substrings_Between_Each_Pair_of_Parentheses;

public class Solution
{
    public string ReverseParentheses(string s) // Optimized logic
    {
        Stack<char> stack = new();
        Queue<char> queue = new();

        foreach (char c in s)
        {
            if (!c.Equals(')')) // we assume that if there is ')' then there should be a '('
                stack.Push(c);
            else
            {
                // pop first then check if equal '(', thus not require the extra '(' pop step
                while (stack.TryPop(out char c1) && !c1.Equals('(')) // pop the '(' as the last one
                    queue.Enqueue(c1);
                while (queue.TryDequeue(out char c2)) // reverse and store back using queue and stack
                    stack.Push(c2);
            }
        }

        string result = "";
        while (stack.TryPop(out char r)) // pop and save as r and store to result string from the last element.
            result = r + result;

        return result;
    }
}

