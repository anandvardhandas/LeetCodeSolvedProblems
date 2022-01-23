public class Solution {
    private int MOD = 1000000007;
    public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn) {
        int[,,] dp = new int[m,n,maxMove+1];
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                for(int k = 0; k <= maxMove; k++){
                    dp[i,j,k] = -1;
                }
            }
        }
        return Helper(m,n,startRow,startColumn,maxMove,dp);
    }
    
    private int Helper(int m, int n, int row, int col, int moveLeft, int[,,] dp){
        if(moveLeft < 0)
            return 0;
        
        if(row < 0 || row >= m || col < 0 || col >= n)
            return 1;
        
        if(dp[row,col,moveLeft] >= 0)
            return dp[row,col,moveLeft];
        
        int result = 0;
        foreach(int[] dir in Directions){
            result = result + Helper(m,n,row+dir[0],col+dir[1],moveLeft-1,dp)%MOD;
            result = result%MOD;
        }
        
        result = result%MOD;
        dp[row,col,moveLeft] = result;
        return result;
    }
    
    private int[][] Directions = new int[4][]{
        new int[] {1,0},
        new int[] {-1,0},
        new int[] {0,1},
        new int[] {0,-1}
    };
}