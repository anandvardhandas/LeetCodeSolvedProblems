public class Solution {
    public int CoinChange(int[] coins, int amount) {
        if(amount == 0)
            return 0;
        
        int[] dp = new int[amount+1];
        int result = Helper(coins, amount, dp);
        if(result == int.MaxValue)
            return -1;
        
        return result;
    }
    
    
    private int Helper(int[] coins, int amount, int[] dp){
        if(amount < 0){
            return int.MaxValue;
        }
        
        if(amount == 0){
            return 0;
        }
        
        if(dp[amount] > 0){
            return dp[amount];
        }
        
        int result = int.MaxValue;
        for(int i = 0; i < coins.Length; i++){
            if(coins[i] < int.MaxValue){
                result = Math.Min(result, Helper(coins, amount - coins[i], dp));
            }
        }
        
        if(result == int.MaxValue){
            dp[amount] = result;
            return result;
        }
        
        dp[amount] = result+1;
        return result + 1;                 
    }
}