public class Solution {
    public int CountSubIslands(int[][] grid1, int[][] grid2) {
        int m = grid1.Length, n = grid1[0].Length;
        
        int count = 0;
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(grid2[i][j] == 1){
                    bool result = Helper(grid1, grid2, m, n, i, j);
                    if(result){
                        count++;
                    }
                }
            }
        }
        
        return count;
    }
    
    private bool Helper(int[][] grid1, int[][] grid2, int m, int n, int i, int j){
        if(i < 0 || i >= m || j < 0 || j >= n || grid2[i][j] == 0){
            return true;
        }
        
        if(grid1[i][j] != grid2[i][j]){
            return false;
        }
        
        grid2[i][j] = 0;
        
        bool result = true;
        foreach(int[] dir in Directions){
            int row = dir[0]+i, col = dir[1]+j;
            bool res = Helper(grid1, grid2, m, n, row, col);
            if(!res){
                result = false;
            }
        }
        
        return result;
    }
    
    private int[][] Directions = new int[4][]{
        new int[] { 1, 0 },
        new int[] { -1, 0 },
        new int[] { 0, -1 },
        new int[] { 0, 1 }
    };
}