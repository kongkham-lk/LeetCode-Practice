using Reverse_Substrings_Between_Each_Pair_of_Parentheses;

string test1 = "(abcd)";
string test2 = "(u(love)i)";
string test3 = "(ed(et(oc))el)";
string test4 = "a(bcdefghijkl(mno)p)q";
string test5 = "yfgnxf";
string test6 = "ta()usw((((a))))";
string test7 = "(sugqlinrwj)gasmtbk";

//Console.WriteLine($"Input: {test1} \nExpect: dcba \nOutput: {new Solution().ReverseParentheses(test1)}\n");
Console.WriteLine($"Input: {test2} \nExpect: iloveu \nOutput: {new Solution().ReverseParentheses(test2)}\n");
//Console.WriteLine($"Input: {test3} \nExpect: leetcode \nOutput: {new Solution().ReverseParentheses(test3)}\n");
//Console.WriteLine($"Input: {test4} \nExpect: apmnolkjihgfedcbq \nOutput: {new Solution().ReverseParentheses(test4)}\n");
//Console.WriteLine($"Input: {test5} \nExpect: yfgnxf \nOutput: {new Solution().ReverseParentheses(test5)}\n");
//Console.WriteLine($"Input: {test6} \nExpect: tauswa \nOutput: {new Solution().ReverseParentheses(test6)}\n");
//Console.WriteLine($"Input: {test7} \nExpect: jwrnilqgusgasmtbk \nOutput: {new Solution().ReverseParentheses(test7)}\n");