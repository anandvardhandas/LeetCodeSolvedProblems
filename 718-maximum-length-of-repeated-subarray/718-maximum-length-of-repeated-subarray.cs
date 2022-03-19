public class Solution {
    public int FindLength(int[] nums1, int[] nums2) {
        int m = nums1.Length, n = nums2.Length;
        int[,] dp = new int[m+1,n+1];
        int maxlen = 0;
        for(int i = 1; i <= m; i++){
            for(int j = 1; j <= n; j++){
                if(nums1[i-1] == nums2[j-1]){
                    dp[i,j] = 1 + dp[i-1,j-1];
                    maxlen = Math.Max(maxlen, dp[i,j]);
                }
            }
        }
    
        return maxlen;
    }
}