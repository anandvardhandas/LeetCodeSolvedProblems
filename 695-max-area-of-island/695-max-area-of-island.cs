public class Solution {
    private int curr = 0;
    public int MaxAreaOfIsland(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        int max = 0;
        
        int[,] visited = new int[m,n];
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(visited[i,j] == 0 && grid[i][j] == 1){
                    curr = 0;
                    Dfs(grid, visited, i, j);
                    max = Math.Max(max,curr);
                }
                    
            }
        }
        
        return max;
    }
    
    private void Dfs(int[][] grid, int[,] visited, int i, int j){
        if(i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || visited[i,j] == 1 || grid[i][j] == 0)
            return;
        
        visited[i,j] = 1;
        curr++;
        foreach(int[] dir in Directions){
            Dfs(grid,visited,i+dir[0],j+dir[1]);
        }
    }
    
    private int[][] Directions = new int[4][]{
        new int[] {0,1},
        new int[] {0,-1},
        new int[] {1,0},
        new int[] {-1,0}
    };
}