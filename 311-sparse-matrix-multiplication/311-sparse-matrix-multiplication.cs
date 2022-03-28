public class Solution {
    public int[][] Multiply(int[][] mat1, int[][] mat2) {
        int m = mat1.Length, n = mat2[0].Length;
        
        int[][] result = new int[m][];
        for(int i = 0; i < m; i++){
            result[i] = new int[n];
            for(int j = 0; j < n; j++){
                int sum = 0;
                for(int k = 0; k < mat1[0].Length; k++){
                    sum += mat1[i][k] * mat2[k][j];
                }
                result[i][j] = sum;
            }
        }
        
        return result;
    }
}