using System;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace Reverse_Substrings_Between_Each_Pair_of_Parentheses;

public class Solution
{
    public string ReverseParentheses(string s) // Optimized logic, using Stack<> and Queue<>. FASTEST
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


    public string ReverseParentheses1(string s) // Optimized logic, using string and Stack<>. EASIER TO UNDERSTAND
    {
        Stack<string> temp = new();
        string result = "";

        foreach (char c in s)
        {
            if (c.Equals('('))
            {
                temp.Push(result); // temp store string outside bracket
                result = ""; // reset string
            }
            else if (c.Equals(')')) // until now, result should only store the string in between the bracket
            {
                result = new string(result.Reverse().ToArray()); // reverse the string
                result = temp.Pop() + result; // combine the outside bracket with the new reverse string
            }
            else
                result += c; // grab all the string the is outside or inbetween the bracket
        }
        return result;
    }
}

