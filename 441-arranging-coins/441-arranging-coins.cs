public class Solution {
    public int ArrangeCoins(int n) {
        long low = 1, hi = n;
        
        long result = 0;
        while(low <= hi){
            long mid = low + (hi-low)/2;
            long coins = (mid * (mid+1))/2;
            if(coins > n){
                hi = mid-1;
            }
            else if(coins <= n){
                result = mid;
                low = mid+1;
            }
        }
        
        return (int)result;
    }
}