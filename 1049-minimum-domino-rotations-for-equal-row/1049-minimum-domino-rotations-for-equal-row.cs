public class Solution {
    public int MinDominoRotations(int[] tops, int[] bottoms) {
        int[] res = new int[6+1];
        int[] ftNum = new int[6];
        int[] fbNum = new int[6];
            
        for (int i = 0; i < tops.Length; i++) {
            if (tops[i] == bottoms[i])
                res[tops[i]]++;
            else {
                res[tops[i]]++;
                res[bottoms[i]]++;
            }
            ftNum[tops[i]-1]++;
            fbNum[bottoms[i]-1]++;
        }
        
        int maxFace = -1;
        int targetFace = -1;
        for (int i = 1; i <= 6; i++) {
            if (maxFace < res[i]) {
                maxFace = res[i];
                targetFace = i - 1;
            }
        }
        if (maxFace == tops.Length)
            return tops.Length - Math.Max(ftNum[targetFace], fbNum[targetFace]);
            
        return -1;
    }
}