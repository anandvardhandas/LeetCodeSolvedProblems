public class Solution {
    public int NumDistinctIslands(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        int[,] visited = new int[m,n];
        int count = 0;
        HashSet<string> map = new HashSet<string>();
        
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                if(grid[i][j] == 1 && visited[i,j] == 0){
                    StringBuilder sb = new StringBuilder();
                    Helper(grid, m, n, i, j, i, j, visited, sb);
                    
                    string key = sb.ToString();
                    if(!map.Contains(key)){
                        count++;
                        map.Add(key);
                    }
                }
            }
        }
        
        return count;
    }
    
    private void Helper(int[][] grid, int m, int n, int r, int c, int row, int col, int[,] visited, StringBuilder sb){
        if(row < 0 || row >= m || col < 0 || col >= n || visited[row,col] == 1 || grid[row][col] == 0)
            return;
        
        visited[row,col] = 1;
        
        string key = $".{row-r}.{col-c}";
        sb.Append(key);
        
        foreach(int[] dir in Directions){
            int nrow = dir[0]+row, ncol = dir[1]+col;
            Helper(grid, m, n, r, c, nrow, ncol, visited, sb);
        }
    }
    
    private int[][] Directions = new int[4][]{
        new int[] { 1, 0 },
        new int[] { -1, 0 },
        new int[] { 0, -1 },
        new int[] { 0, 1 }
    };
}