public class Solution {
    public int NumIslands(char[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        int count = 0;
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(grid[i][j] == '1'){
                    Helper(grid, m, n, i, j);
                    count++;
                }
            }
        }
        
        return count;
    }
    
    private void Helper(char[][] grid, int m, int n, int x, int y){
        if(x < 0 || x >= m || y < 0 || y >= n || grid[x][y] == '0'){
            return;
        }
        
        grid[x][y] = '0';
        foreach(int[] dir in Directions){
            int row = dir[0]+x, col = dir[1]+y;
            Helper(grid, m, n, row, col);
        }
    }
    
    private int[][] Directions = new int[4][]{
        new int[] {1,0},
        new int[] {-1,0},
        new int[] {0,1},
        new int[] {0,-1}
    };
}