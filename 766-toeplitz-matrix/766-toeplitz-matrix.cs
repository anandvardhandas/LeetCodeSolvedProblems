public class Solution {
    public bool IsToeplitzMatrix(int[][] matrix) {
           
        int m = matrix.Length, n = matrix[0].Length;
        
        for(int i = 0; i < m-1; i++){
            for(int j = 0; j < n-1; j++){
                if(matrix[i][j] != matrix[i+1][j+1])
                    return false;
            }
        }
        
        return true;
    }
}