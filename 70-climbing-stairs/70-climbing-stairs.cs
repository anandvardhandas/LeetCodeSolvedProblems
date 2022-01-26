public class Solution {
    public int ClimbStairs(int n) {
        int[] dp = new int[n+1];
        return Helper(n, 1, dp);
    }
    
    private int Helper(int n, int i, int[] dp){
        if(i >= n){
            return 1;
        }
        
        if(dp[i] > 0)
            return dp[i];
        
        int result = 0;
        result += Helper(n, i+1, dp);
        result += Helper(n, i+2, dp);
        
        dp[i] = result;
        return result;
    }
}