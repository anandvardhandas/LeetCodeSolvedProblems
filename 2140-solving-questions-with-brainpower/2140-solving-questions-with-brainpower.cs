public class Solution {
    public long MostPoints(int[][] questions) {
       int len = questions.Length;
        long[] dp = new long[len+1];
        
        for(int i = len-1; i >= 0; i--){
            long skip = dp[i+1];
            long continuePart = questions[i][0];
            if(i+questions[i][1]+1 < len)
                continuePart += dp[i+questions[i][1]+1];
            dp[i] = Math.Max(skip, continuePart);
        }
        
       return dp[0];
    }
   
}