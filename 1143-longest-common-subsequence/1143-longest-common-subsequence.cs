public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        int m = text1.Length, n = text2.Length;
        int[,] dp = new int[m+1,n+1];
        for(int i = 0; i <= m; i++){
            for(int j = 0; j <= n; j++){
                dp[i,j] = -1;
            }
        }
        return Helper(text1, text2, 0, 0, dp);
    }
    
    private int Helper(string text1, string text2, int i, int j, int[,] dp){
        if(i >= text1.Length || j >= text2.Length)
            return 0;
        
        if(dp[i,j] >= 0){
            return dp[i,j];
        }
        
        int len1 = 0, len2 = 0, len3 = 0;
        if(text1[i] == text2[j]){
            len1 = 1 + Helper(text1, text2, i+1, j+1, dp);
        }
        else{
            len2 = Helper(text1, text2, i, j+1, dp);
            len3 = Helper(text1, text2, i+1, j, dp);
        }
        
        int maxlen = Math.Max(len1, Math.Max(len2, len3));
        dp[i,j] = maxlen;
        return maxlen;
    }
}