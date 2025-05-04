public class Solution {
    // Solution 2 - Optimized
    // No need to check for every face, if any rotation that not match the first rotation then its already wrong
    public int MinDominoRotations(int[] tops, int[] bottoms) {
        int res;
        if (tops[0] != bottoms[0])
            res = Math.Min(GetRotation(tops, bottoms, tops[0]), GetRotation(tops, bottoms, bottoms[0]));
        else
            res = GetRotation(tops, bottoms, tops[0]);
        return res == int.MaxValue ? -1 : res;
    }

    private int GetRotation(int[] tops, int[] bottoms, int target) {
        int t = 0, b = 0;

        for (int i = 0; i < tops.Length; i++) {
            if (tops[i] != target && bottoms[i] != target)
                return int.MaxValue;

            if (tops[i] != target) t++;
            else if (bottoms[i] != target) b++;
        }
        return Math.Min(t, b);
    }

    // // Solution 1 - Initial
    // public int MinDominoRotations(int[] tops, int[] bottoms) {
    //     int[] res = new int[6+1];
    //     int[] ftNum = new int[6];
    //     int[] fbNum = new int[6];
            
    //     for (int i = 0; i < tops.Length; i++) {
    //         if (tops[i] == bottoms[i])
    //             res[tops[i]]++;
    //         else {
    //             res[tops[i]]++;
    //             res[bottoms[i]]++;
    //         }
    //         ftNum[tops[i]-1]++;
    //         fbNum[bottoms[i]-1]++;
    //     }
        
    //     int maxFace = -1;
    //     int targetFace = -1;
    //     for (int i = 1; i <= 6; i++) {
    //         if (maxFace < res[i]) {
    //             maxFace = res[i];
    //             targetFace = i - 1;
    //         }
    //     }
    //     if (maxFace == tops.Length)
    //         return tops.Length - Math.Max(ftNum[targetFace], fbNum[targetFace]);
            
    //     return -1;
    // }
}