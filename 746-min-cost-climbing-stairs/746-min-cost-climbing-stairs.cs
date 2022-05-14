public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int[] dp = new int[cost.Length+1];
        
        for(int i = 0; i < dp.Length; i++){
            dp[i] = -1;
        }
        
        int res1 = Helper(cost, 0, dp);
        
        for(int i = 0; i < dp.Length; i++){
            dp[i] = -1;
        }
        
        int res2 = Helper(cost, 1, dp);
        
        return Math.Min(res1,res2);
    }
    
    private int Helper(int[] cost, int index, int[] dp){
        if(index >= cost.Length)
            return 0;
        
        
        if(dp[index] != -1)
            return dp[index];
        
        int res1 = int.MaxValue, res2 = int.MaxValue;
        //climb 1 step
        res1 = Helper(cost, index+1, dp);
        
        //climb 2 steps
        res2 = Helper(cost, index+2, dp);
        
        if(res1 != int.MaxValue){
            res1 += cost[index];
        }
        
        if(res2 != int.MaxValue){
            res2 += cost[index];
        }
        
        int result = Math.Min(res1,res2);
        
        dp[index] = result;
        return result;
    }
}