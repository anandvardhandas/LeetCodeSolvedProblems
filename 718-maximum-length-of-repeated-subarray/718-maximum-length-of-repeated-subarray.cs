public class Solution {
    public int FindLength(int[] nums1, int[] nums2) {
        int m = nums1.Length, n = nums2.Length;
        int maxlen = 0;
        int[,] dp = new int[m+1,n+1];
        for(int i = m-1; i >= 0; i--){
            for(int j = n-1; j >= 0; j--){
                if(nums1[i] == nums2[j]){
                    dp[i,j] = 1 + dp[i+1,j+1];
                    maxlen = Math.Max(maxlen, dp[i,j]);
                }
            }
        }
        
        return maxlen;
    }
}