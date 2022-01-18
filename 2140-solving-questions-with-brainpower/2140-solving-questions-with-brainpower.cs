public class Solution {
    public long MostPoints(int[][] questions) {
       long[] dp = new long[questions.Length];
       return Helper(questions, 0, dp);
    }
    
    private long Helper(int[][] questions, int index, long[] dp){
        if(index >= questions.Length)
            return 0;
        
        if(dp[index] > 0)
            return dp[index];
        
        long maxPoints = Math.Max(questions[index][0] + Helper(questions, index+questions[index][1]+1, dp), Helper(questions, index+1, dp));
        
        dp[index] = maxPoints;
        return dp[index];
    }
}