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
            if (!c.Equals(')'))
                stack.Push(c);
            else
            {
                while (stack.TryPop(out char c1) && !c1.Equals('('))
                {
                    Console.WriteLine("c1 is: " + c1);
                    queue.Enqueue(c1);
                }
                Console.WriteLine("Start insert back!!!");
                while (queue.TryDequeue(out char c2))
                    stack.Push(c2);
                Console.WriteLine("Done back!!!");
            }
        }

        string result = "";
        while (stack.TryPop(out char r))
            result = r + result;

        return result;
    }
}

