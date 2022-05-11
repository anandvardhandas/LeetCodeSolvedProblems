public class Solution {
    public int CountNegatives(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        
        int total = 0;
        
        for(int i = 0; i < m; i++){
            int low = 0, hi = n-1;
            int negindex = -1;
            while(low <= hi){
                int mid = low + (hi-low)/2;
                if(grid[i][mid] < 0){
                    negindex = mid;
                    hi = mid-1;
                }
                else{
                    low = mid+1;
                }
            }
            
            if(negindex != -1)
                total += n - negindex;
        }
        
        return total;
    }
}