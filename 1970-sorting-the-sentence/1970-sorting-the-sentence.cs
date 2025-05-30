public class Solution {
    public string SortSentence(string s) {
        if (s.Length == 0) return s;

        Dictionary<int, string> memo = new Dictionary<int, string>();
        string txt = "";
        string order = "";
        string num = "0123456789";
        for (int i = s.Length-1; i >= 0; i--) {
            string t = s[i].ToString();
            if (num.Contains(t)) {
                order = t + order;
            } else if (t.Equals(" ")) {
                // Console.WriteLine(order + ", " + txt);
                memo.Add(Int32.Parse(order), txt);
                order = txt = "";
            } else {
                txt = t + txt;
            }
        }
        // Console.WriteLine(order + ", " + txt);
        memo.Add(Int32.Parse(order), txt);
        txt = memo[1];
        for (int i = 2; i <= memo.Count(); i++)
            txt += " " + memo[i];

        return txt;
    }
}