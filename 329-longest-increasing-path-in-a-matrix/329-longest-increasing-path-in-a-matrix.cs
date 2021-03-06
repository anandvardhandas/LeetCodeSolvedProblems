public class Solution {
    private int maxscore;
    public int LongestIncreasingPath(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        this.maxscore = 0;
        
        int[,] score = new int[m,n];
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(score[i,j] == 0){
                    Helper(grid, m, n, i, j, score, -1);
                }
            }
        }
        
       return this.maxscore;
    }
    
    private int Helper(int[][] grid, int m, int n, int i, int j, int[,] score, int prev){
        if(i < 0 || i >= m || j < 0 || j >= n || grid[i][j] <= prev){
            return 0;
        }
        
        if(score[i,j] != 0){
            return score[i,j];
        }
        
        int max = 0;
        foreach(int[] dir in Directions){
            int row = dir[0]+i, col = dir[1]+j;
            max = Math.Max(max, Helper(grid, m, n, row, col, score, grid[i][j]));
        }
        
        score[i,j] = max+1;
        
        this.maxscore = Math.Max(this.maxscore, score[i,j]);
        return score[i,j];
    }
    
    private int[][] Directions = new int[4][]{
        new int[] { 1, 0 },
        new int[] { -1, 0 },
        new int[] { 0, 1 },
        new int[] { 0, -1 }
    };
}