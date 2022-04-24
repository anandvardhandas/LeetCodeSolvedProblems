public class Solution {
    public int IslandPerimeter(int[][] grid) {
        
        int m = grid.Length, n = grid[0].Length;
        
        int[,] visited = new int[m,n];
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(grid[i][j] == 1){
                    Helper(grid, i, j, visited);
                    return total;
                }
            }
        }
        
        
        return total;
    }
    
    private void Helper(int[][] grid, int i, int j, int[,] visited){
        if(i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] == 0 || visited[i,j] == 1)
            return;
        
        visited[i,j] = 1;
        
        foreach(int[] dir in Directions){
            int row = i+dir[0], col = j+dir[1];
            if(row < 0 || row >= grid.Length || col < 0 || col >= grid[0].Length || grid[row][col] == 0){
                total++;
            }
        }
        
        foreach(int[] dir in Directions){
            Helper(grid, i+dir[0], j+dir[1], visited);
        }
    }
    
    private int total = 0;
    
    private int[][] Directions = new int[4][]{
        new int[] { 1, 0},
        new int[] { -1, 0},
        new int[] { 0, 1},
        new int[] { 0, -1}
    };
}