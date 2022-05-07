public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        HashSet<string> map = new HashSet<string>(wordDict);
        int[] dp = new int[s.Length];
        for(int i = 0; i < s.Length; i++){
            dp[i] = -1;
        }
        
        return Helper(s, map, 0, dp) == 1;
    }
    
    private int Helper(string s, HashSet<string> map, int index, int[] dp){
        if(index == s.Length){
            return 1;
        }
        
        if(dp[index] != -1){
            return dp[index];
        }
        
        
        for(int i = index; i < s.Length; i++){
            if(map.Contains(s.Substring(index,i-index+1)) && Helper(s, map, i+1, dp) == 1){
                dp[index] = 1;
                return 1;
            }
        }
        
        dp[index] = 0;
        return 0;
    }
}