using Reverse_Substrings_Between_Each_Pair_of_Parentheses;

string test1 = "(abcd)";
string test2 = "(u(love)i)";
string test3 = "(ed(et(oc))el)";
string test4 = "a(bcdefghijkl(mno)p)q";

Console.WriteLine($"Input: {test1} \nExpected: dcba \nOutput: {new Solution().ReverseParentheses(test1)}\n");
Console.WriteLine($"Input: {test2} \nExpected: iloveu \nOutput: {new Solution().ReverseParentheses(test2)}\n");
Console.WriteLine($"Input: {test3} \nExpected: leetcode \nOutput: {new Solution().ReverseParentheses(test3)}\n");
Console.WriteLine($"Input: {test4} \nExpected: apmnolkjihgfedcbq \nOutput: {new Solution().ReverseParentheses(test4)}\n");