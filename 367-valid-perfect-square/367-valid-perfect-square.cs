public class Solution {
    public bool IsPerfectSquare(int num) {
        long low = 1, hi = num;
        
        while(low <= hi){
            long mid = low + (hi-low)/2;
            long result = mid * mid;
            if(result > num){
                hi = mid-1;
            }
            else if(result < num){
                low = mid+1;
            }
            else{
                return true;;
            }
        }
        
        return false;
    }
}
