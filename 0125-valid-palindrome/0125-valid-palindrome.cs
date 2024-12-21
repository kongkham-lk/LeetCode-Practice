public class Solution {
        public bool IsPalindrome(string s)
        {
            s = s.ToLower();
            string resultStr = "";
            foreach (char c in s)
                if (isAlphabet(c))
                    resultStr += c;

            int sizeStr = resultStr.Length;
            if (sizeStr <= 1)
                return true;

            int l = 0;
            int r = sizeStr - 1;
            while (l < r)
            {
                if (!resultStr[l].Equals(resultStr[r]))
                    return false;
                l++;
                r--;
            }
            return true;
        }

        private bool isAlphabet(char c)
        {
            return c >= 'a' && c <= 'z' || c >= '0' && c <= '9';
        }
}