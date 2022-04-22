public class Solution {
    public bool IsToeplitzMatrix(int[][] matrix) {
           
        int m = matrix.Length, n = matrix[0].Length;
        for(int i = 0; i < n; i++){
            if(!Helper(matrix, m, n, 0, i))
                return false;
        }
        
        for(int i = m-1; i > 0; i--){
            if(!Helper(matrix, m, n, i, 0))
                return false;
        }
        
        return true;
        
    }
    
    private bool Helper(int[][] matrix, int m, int n, int x, int y){
        if(x >= m-1 || y >= n-1)
            return true;
        
        if(matrix[x][y] != matrix[x+1][y+1]){
            return false;
        }
        
        return Helper(matrix, m, n, x+1, y+1);
    }
    
    
}