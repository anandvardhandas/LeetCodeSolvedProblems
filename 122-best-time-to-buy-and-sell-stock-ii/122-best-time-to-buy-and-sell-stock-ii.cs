public class Solution {
    public int MaxProfit(int[] prices) {
        int len = prices.Length;
        int maxprofit = 0;
        int cprofit = 0;
        int lastbuy = prices[0];
        for(int i = 1; i < len; i++){
            if(prices[i] > prices[i-1]){
                cprofit = prices[i]-lastbuy;
            }
            else{
                maxprofit += cprofit;
                cprofit = 0;
                lastbuy = prices[i];
            }
        }
        
        if(cprofit > 0){
            maxprofit += cprofit;
        }
        
        return maxprofit;
    }
}