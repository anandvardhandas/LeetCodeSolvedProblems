public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        int m = text1.Length, n = text2.Length;
        int[,] dp = new int[m+1,n+1];
        for(int i = m-1; i >= 0; i--){
            for(int j = n-1; j >= 0; j--){
                int len1 = 0, len2 = 0, len3 = 0;
                if(text1[i] == text2[j]){
                    len1 = 1 + dp[i+1,j+1];
                }
                else{
                    len2 = dp[i,j+1];
                    len3 = dp[i+1,j];
                }

                int maxlen = Math.Max(len1, Math.Max(len2, len3));
                dp[i,j] = maxlen;
            }
        }
        
        return dp[0,0];
    }
}