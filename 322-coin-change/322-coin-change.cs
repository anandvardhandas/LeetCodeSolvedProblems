public class Solution {
    public int CoinChange(int[] coins, int amount) {
        if(amount == 0)
            return 0;
        
        Array.Sort(coins);
        
        int[] dp = new int[amount+1];
        int result = Helper(coins, amount, 0, dp);
        if(result == int.MaxValue)
            return -1;
        
        return result;
    }
    
    
    private int Helper(int[] coins, int amount, int used, int[] dp){
        if(used > amount){
            return int.MaxValue;
        }
        
        if(used == amount){
            return 0;
        }
        
        if(dp[used] > 0){
            return dp[used];
        }
        
        int result = int.MaxValue;
        for(int i = 0; i < coins.Length; i++){
            if(coins[i] < int.MaxValue){
                result = Math.Min(result, Helper(coins, amount, used+coins[i], dp));
            }
        }
        
        if(result == int.MaxValue){
            dp[used] = result;
            return result;
        }
        
        dp[used] = result+1;
        return result + 1;                 
    }
}