public class Solution {
    public int MaxProfit(int[] prices) {
        int len = prices.Length;
        int maxprofit = 0;
        int buy = prices[0];
        for(int i = 1; i < len; i++){
            if(prices[i] <= buy){
                buy = prices[i];
            }
            
            maxprofit = Math.Max(maxprofit, prices[i]-buy);
        }
        
        return maxprofit;
    }
}