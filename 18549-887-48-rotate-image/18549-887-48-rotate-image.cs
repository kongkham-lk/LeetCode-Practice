public class Solution {
    public void Rotate(int[][] matrix) {
        int size = matrix.Length;
        int offset = size % 2 == 0 ? 1 : 0;

        for (int i = 0; i < size / 2; i++) {
            for (int j = i; j < size - 1 - i; j++) {
                int temp = matrix[i][j];
                int lastRowInd = size - 1 - i;
                int lastColInd = size - 1 - j;
                matrix[i][j] = matrix[lastColInd][i];
                matrix[lastColInd][i] = matrix[lastRowInd][lastColInd];
                matrix[lastRowInd][lastColInd] = matrix[j][lastRowInd];
                matrix[j][lastRowInd] = temp;
                // Console.WriteLine(matrix[i][j] + ", " + matrix[lastColInd][i] + ", " + matrix[lastRowInd][lastColInd] + ", " + matrix[j][lastRowInd]);
            }
        }
    }
}