public class Solution {
        public bool IsPalindrome(string s)
        {
            string resultStr = "";
            foreach (char c in s)
                if (isAlphabet(c))
                    resultStr += Char.ToLower(c);

            if (!resultStr.Any())
                return true;

            if (resultStr.Equals(string.Join("",resultStr.Reverse())))
                return true;
            else
                return false;
        }

        private bool isAlphabet(char c)
        {
            return char.IsNumber(c) || char.IsLetter(c);
        }
}