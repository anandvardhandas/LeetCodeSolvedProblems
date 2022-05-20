public class Solution {
    public int UniquePathsWithObstacles(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        
        if(grid[0][0] == 1 || grid[m-1][n-1] == 1){
            return 0;
        }
        
        int[,] dp = new int[m,n];
        return Helper(grid, m, n, 0, 0, dp);
    }
    
    private int Helper(int[][] grid, int m, int n, int i, int j, int[,] dp){
        if(i < 0 || i >= m || j < 0 || j >= n || grid[i][j] == 1){
            return 0;
        }
        
        if(i == m-1 && j == n-1){
            return 1;
        }
        
        if(dp[i,j] > 0){
            return dp[i,j];
        }
        
        int right = Helper(grid, m, n, i, j+1, dp);
        int left = Helper(grid, m, n, i+1, j, dp);
        
        int total = left+right;
        
        dp[i,j] = total;
        return total;
    }
}