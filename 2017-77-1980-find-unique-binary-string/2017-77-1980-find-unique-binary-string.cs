public class Solution {
    public string FindDifferentBinaryString(string[] nums) {
            List<string> memo = new List<string>();
            int lastSize = 0; // tracking the previous size of memo for comparison at a time
            string zeros = "";
            // Iitialized all the require pre zero for 1 bit number
            for (int j = 0; j < nums.Length - 1; j++)
                zeros += '0';
            for (int i = 0; i < nums.Length; i++)
            {
                // Initialized the first 2 bit (1 digit bit)
                if (!memo.Any())
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (!nums.Contains(zeros + (j)))
                            return zeros + (j);
                        memo.Add("" + j);
                    }
                }
                else
                {
                    // each 0 and 1 of new digit will has all the element of memo list from 0 to prev memo size
                    for (int j = 0; j < 2; j++)
                    {
                        for (int k = 0; k < lastSize; k++)
                        {
                            // reduce the number of zeros as the digit of bit store in memo list increased.
                            string targetZeros = zeros.Substring(memo[k].Length);
                            if (!nums.Contains(targetZeros + (j) + memo[k]))
                                return targetZeros + (j) + memo[k];
                            memo.Add(j + memo[k]);
                        }
                    }
                }
                lastSize = memo.Count;
            }

            return "";
    }
}