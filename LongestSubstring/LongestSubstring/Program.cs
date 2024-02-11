public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(LengthOfLongestSubstring("au"));
        Console.WriteLine(LengthOfLongestSubstring("bbbbbbbbb"));
        Console.WriteLine(LengthOfLongestSubstring("pwwkupk"));
    }

    public static int LengthOfLongestSubstring(string s)
    {
        int l = 0;
        int r = 0;
        int length = 0;
        string memo = "";

        if (s.Length < 1)
            return 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (i == 0)
                memo = s[l].ToString();
            else if (!memo.Contains(s[i]))
                memo += s[i].ToString();
            else
            {
                if (!s[i].Equals(s[r]))
                {
                    while (s[l] != s[i])
                        l++;
                    l++;

                    memo = s.Substring(l, i-l+1);
                }
                else
                {
                    l = i;
                    memo = s[i].ToString();
                }
            }

            int newLength = memo.Length;
            if (length < newLength)
                length = newLength;

            r = i;
        }
        return length;
    }
}