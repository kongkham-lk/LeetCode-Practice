public class Solution {
    public bool IsValid(string s) {
            Stack<char> memo = new Stack<char>();
            List<char> openSym = new List<char>() { '(', '{', '[' };
            List<char> closeSym = new List<char>() { ')', '}', ']' };

            foreach (char sym in s)
            {
                if (openSym.Contains(sym))
                {
                    int index = openSym.IndexOf(sym);
                    memo.Push(closeSym[index]);
                }
                else
                {
                    if (!memo.Any())
                        return false;
                    char targetCloseSym = memo.Pop();
                    if (!targetCloseSym.Equals(sym))
                        return false;
                }
            }

            if (memo.Any())
                return false;
            return true;
    }
}