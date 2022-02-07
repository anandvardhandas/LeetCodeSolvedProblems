public class Solution {
    public int NthUglyNumber(int n) {
        if(n == 1)
            return 1;
        int[] dp = new int[n+1];
        dp[0] = 1;
        //three pointers to keep track of multiples of 2,3 & 5
        int p2 = 0; 
        int p3 = 0; 
        int p5 = 0;
        
        for(int i = 1; i < n; i++){
            int mult2 = dp[p2] * 2;
            int mult3 = dp[p3] * 3;
            int mult5 = dp[p5] * 5;
            
            //calculate minimum of these 3 for the next ugly number
            int min = Math.Min(mult2, Math.Min(mult3,mult5));
            dp[i] = min;
            
            //incrementing the pointers
            if(mult2 == min)
                p2++;
            if(mult3 == min)
                p3++;
            if(mult5 == min)
                p5++;
        }
        
        return dp[n-1];
    }
}