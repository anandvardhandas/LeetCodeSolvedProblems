public class Solution {
    public int[][] Transpose(int[][] matrix) {
        int m = matrix.Length, n = matrix[0].Length;
        int[,] result = new int[n,m];
        
        for(int row = 0; row < m; row++){
            for(int col = 0; col < n; col++){
                result[col,row] = matrix[row][col];
            }
        }
        
        return ConvertToJaggedArray(result, n, m);    
    }
    
    private int[][] ConvertToJaggedArray(int[,] arr, int row, int col){
        int[][] result = new int[row][];
        for(int i = 0; i < row; i++){
            result[i] = new int[col];
            for(int j = 0; j < result[i].Length; j++){
                result[i][j] = arr[i,j];
            }
        }
        
        return result;
    }
}