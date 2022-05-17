public class Solution {
    public int[][] UpdateMatrix(int[][] mat) {
        int m = mat.Length, n = mat[0].Length;
        
        for(int row = 0; row < m; row++){
            for(int col = 0; col < n; col++){
                if(mat[row][col] != 0){
                    //check for top
                    int min = int.MaxValue;
                    if(row > 0){
                        min = Math.Min(min, mat[row-1][col]);
                    }
                    
                    //check for left
                    if(col > 0){
                        min = Math.Min(min, mat[row][col-1]);
                    }
                    
                    if(min != int.MaxValue){
                        mat[row][col] = min+1;
                    }
                    else{
                        mat[row][col] = int.MaxValue;
                    }
                }
            }
        }
        
        for(int row = m-1; row >= 0; row--){
            for(int col = n-1; col >= 0; col--){
                if(mat[row][col] != 0){
                    //check for right
                    int min = mat[row][col]-1;
                    if(col < n-1){
                        min = Math.Min(min, mat[row][col+1]);
                    }
                    
                    //check for bottom
                    if(row < m-1){
                        min = Math.Min(min, mat[row+1][col]);
                    }
                    
                    if(min != int.MaxValue){
                        mat[row][col] = min+1;
                    }
                }
            }
        }
        
        return mat;
    }
}