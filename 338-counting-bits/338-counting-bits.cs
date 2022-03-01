public class Solution {
    public int[] CountBits(int n) {
        int[] result = new int[n+1];
        
        for(int i = 1; i <= n; i++){
            //here using the fact that if we right shift any number by 1, then number of 1s will be same as number of 1s n>>1 will have and if the current number is odd then it will have 1 more 1. hence adding num & 1
            result[i] = result[i>>1] + (i & 1);
        }
        
        return result;
    }
    
    
}