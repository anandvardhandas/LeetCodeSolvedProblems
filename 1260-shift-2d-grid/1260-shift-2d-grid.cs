public class Solution {
    public IList<IList<int>> ShiftGrid(int[][] grid, int k) {
        int m = grid.Length, n = grid[0].Length;
        
        k = k % (m*n);
        
        int[][] result = new int[m][];
        
        for(int i = 0; i < m; i++){
            result[i] = new int[n];
        }
        
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                int col = (j+k)%n;
                int row = (i + ((j+k)/n))%m;
                
                result[row][col] = grid[i][j];
            }
        }
        
        return result;
    }
}