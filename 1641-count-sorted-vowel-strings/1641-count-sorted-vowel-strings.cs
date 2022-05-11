public class Solution {
    public int CountVowelStrings(int n) {
        char[] arr = new char[] { 'a', 'e', 'i', 'o', 'u' };
        List<string> result = new List<string>();
        int[,] dp = new int[n,5];
        for(int i = 0; i < n; i++){
            for(int j = 0; j < 5; j++){
                dp[i,j] = -1;
            }
        }
        return Helper(n, arr, 0, 0, dp);
    }
    
    private int Helper(int n, char[] arr, int index, int len, int[,] dp){
        if(index >= arr.Length){
            return 0;
        }
        
        if(len == n){
            return 1;
        }
        
        if(dp[len,index] != -1){
            return dp[len,index];
        }
        
        int result = 0;
        for(int i = index; i < arr.Length; i++){
            result += Helper(n, arr, i, len+1, dp);
        }
        
        dp[len,index] = result;
        return result;
    }
}