public class Solution {
    public int MySqrt(int x) {
        if(x == 0)
            return 0;
        
        int low = 1, hi = x/2;
        
        int result = low;
        while(low <= hi){
            int mid = low + (hi-low)/2;
            if((long)mid*mid > x){
                hi = mid-1;
            }
            else{
                result = mid;
                low = mid+1;
            }
        }
        
        return result;
    }
}