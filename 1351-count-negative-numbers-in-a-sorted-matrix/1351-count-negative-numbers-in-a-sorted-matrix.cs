public class Solution {
    public int CountNegatives(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        
        int total = 0;
        
        int col = n-1;
        for(int i = 0; i < m; i++){
            while(col >= 0 && grid[i][col] < 0){
                col--;
            }
            
            total += n-col-1;
        }
        
        return total;
    }
}