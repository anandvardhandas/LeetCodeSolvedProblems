public class Solution {
    public int UniquePathsWithObstacles(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        
        if(grid[0][0] == 1 || grid[m-1][n-1] == 1){
            return 0;
        }
        
        int[,] dp = new int[m+1,n+1];
        dp[m-1,n-1] = 1;
        
        for(int i = m-1; i >= 0; i--){
            for(int j = n-1; j >= 0; j--){
                if(grid[i][j] == 1){
                    continue;
                }
                
                dp[i,j] += dp[i,j+1]+dp[i+1,j];
            }
        }
        
        return dp[0,0];
    }
    
    
}