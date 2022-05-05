public class Solution {
    public int MinFlipsMonoIncr(string s) {
        int[,] dp = new int[s.Length,2];
        for(int i = 0; i < s.Length; i++){
            dp[i,0] = -1;
            dp[i,1] = -1;
        }
        
        return Helper(s,0,0, dp);
    }
    
    private int Helper(string s, int index, int prev, int[,] dp){
        if(index == s.Length){
            return 0;
        }
        
        if(dp[index,prev] != -1){
            return dp[index,prev];
        }
        
        int result1 = int.MaxValue, result2 = int.MaxValue, result3 = int.MaxValue;
        if(prev == 0){
            result1 = Helper(s, index+1, 0, dp);
            if(s[index] == '1'){
                result1 += 1;
            }
            
            result2 = Helper(s, index+1, 1, dp);
            if(s[index] == '0'){
                result2 += 1;
            }
            
        }
        else{
            result3 = Helper(s, index+1, 1, dp);
            if(s[index] == '0'){
                result3 += 1;
            }
        }
        
        int result = Math.Min(result1, Math.Min(result2, result3));
        dp[index,prev] = result;
        return result;
    }
}