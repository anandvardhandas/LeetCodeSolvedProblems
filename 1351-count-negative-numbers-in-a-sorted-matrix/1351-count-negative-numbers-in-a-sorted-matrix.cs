public class Solution {
    public int CountNegatives(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        int total = 0;
        
        int i = 0, j = n-1;
        
        while(i < m){
            while(i < m && j >= 0 && grid[i][j] < 0){
                j--;
            }

            total += n-j-1;
            //Console.WriteLine(j);
            i++;
        }
        
        
        return total;
    }
}