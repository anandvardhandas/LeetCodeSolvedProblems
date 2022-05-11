public class Solution {
    public int CountNegatives(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        
        int total = 0;
        
        int negindex = n;
        for(int i = 0; i < m; i++){
            int low = 0;
            int hi = negindex-1;
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
            
            //Console.WriteLine(negindex);
            total += n-negindex;
        }
        
        return total;
    }
}