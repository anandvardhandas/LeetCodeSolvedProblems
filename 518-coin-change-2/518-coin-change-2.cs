public class Solution {
    public int Change(int amount, int[] coins) {
        int m = coins.Length, n = amount;
        int[,] dp = new int[m,n];
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                dp[i,j] = -1;
            }
        }
        
        return Helper(coins, amount, 0, 0, dp);
    }
    
    private int Helper(int[] coins, int amount, int index, int currentAmount, int[,] dp){
        if(amount == currentAmount)
            return 1;
        
        if(index >= coins.Length || currentAmount > amount)
            return 0;
        
        if(dp[index,currentAmount] >= 0){
            return dp[index,currentAmount];
        }
        
        int include = 0, notInclude = 0;
        include = Helper(coins, amount, index, currentAmount+coins[index], dp);
        
        notInclude = Helper(coins, amount, index+1, currentAmount, dp);
        
        int total = include+notInclude;
        dp[index,currentAmount] = total;
        return total;
    }
}