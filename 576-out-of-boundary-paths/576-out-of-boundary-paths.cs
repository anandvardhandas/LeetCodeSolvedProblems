public class Solution {
    private int MOD = 1000000007;
    public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn) {
        Dictionary<string,int> dp = new Dictionary<string,int>();
        return Helper(m,n,startRow,startColumn,maxMove,dp);
    }
    
    private int Helper(int m, int n, int row, int col, int moveLeft, Dictionary<string,int> dp){
        if(moveLeft < 0)
            return 0;
        
        if(row < 0 || row >= m || col < 0 || col >= n)
            return 1;
        
        if(dp.ContainsKey($"{row}-{col}-{moveLeft}"))
            return dp[$"{row}-{col}-{moveLeft}"];
        
        int result = 0;
        foreach(int[] dir in Directions){
            result = result + Helper(m,n,row+dir[0],col+dir[1],moveLeft-1,dp)%MOD;
            result = result%MOD;
        }
        
        result = result%MOD;
        dp.Add($"{row}-{col}-{moveLeft}", result);
        return result;
    }
    
    private int[][] Directions = new int[4][]{
        new int[] {1,0},
        new int[] {-1,0},
        new int[] {0,1},
        new int[] {0,-1}
    };
}