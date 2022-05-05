public class Solution {
    public int NumIslands(char[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        
        int islands = 0;
        
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(grid[i][j] == '1'){
                    Helper(grid, i, j);
                    islands++;
                }
            }
        }
        
        return islands;
    }
    
    private void Helper(char[][] grid, int row, int col){
        if(row < 0 || row >= grid.Length || col < 0 || col >= grid[0].Length || grid[row][col] == '0'){
            return;
        }
        
        grid[row][col] = '0';
        foreach(int[] dir in Directions){
            int nrow = dir[0]+row, ncol = dir[1]+col;
            Helper(grid, nrow, ncol);
        }
    }
    
    private int[][] Directions = new int[4][]{
        new int[] {1,0},
        new int[] {-1,0},
        new int[] {0,1},
        new int[] {0,-1}
    };
}