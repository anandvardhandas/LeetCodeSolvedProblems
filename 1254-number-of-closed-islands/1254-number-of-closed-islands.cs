public class Solution {
    public int ClosedIsland(int[][] grid) {
        int total = 0;
        int m = grid.Length, n = grid[0].Length;
        int[,] visited = new int[m,n];
        for(int i =  0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(visited[i,j] == 0 && grid[i][j] == 0){
                    bool res = Helper(grid, m, n, i, j, visited);
                    if(res){
                        total++;
                    }
                }
            }
        }
        
        return total;
    }
    
    private bool Helper(int[][] grid, int m, int n, int i, int j, int[,] visited){
        if(i < 0 || i >= m || j < 0 || j >= n)
            return false;
        
        if(visited[i,j] == 1 || grid[i][j] == 1){
            return true;
        }
        
        visited[i,j] = 1;
        
        bool result = true;
        foreach(int[] dir in Directions){
            int row = dir[0]+i, col = dir[1]+j;
            bool res = Helper(grid, m, n, row, col, visited);
            if(!res){
                result = false;
            }
        }
        
        return result;
    }
    
     private int[][] Directions = new int[4][]{
        new int[] {1,0},
        new int[] {-1,0},
        new int[] {0,1},
        new int[] {0,-1}
    };
}