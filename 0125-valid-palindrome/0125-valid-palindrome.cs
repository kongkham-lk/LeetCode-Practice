public class Solution {
        public bool IsPalindrome(string s)
        {
            string resultStr = "";
            foreach (char c in s)
                if (isAlphabet(c))
                    resultStr += Char.ToLower(c);

            if (!resultStr.Any())
                return true;

            // option 1
            if (resultStr.Equals(string.Join("",resultStr.Reverse())))
                return true;
            else
                return false;
            
            // //option 2
            // int l = 0;
            // int r = resultStr.Length - 1;
            // while (l <= r)
            // {
            //     if (!resultStr[l].Equals(resultStr[r]))
            //         return false;
            //     l++;
            //     r--;
            // }
            // return true;
        }

        private bool isAlphabet(char c)
        {
            return char.IsNumber(c) || char.IsLetter(c);
        }
}