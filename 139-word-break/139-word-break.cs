public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
            HashSet<string> map = new HashSet<string>(wordDict);
        int[] dp = new int[s.Length];
        for(int i = 0; i < s.Length; i++){
            dp[i] = -1;
        }
        return Helper(s, map, 0, dp) == 1;
    }
    
    private int Helper(string s, HashSet<string> map, int start, int[] dp){
        if(start == s.Length){
            return 1;
        }
        
        if(dp[start] != -1){
            return dp[start];
        }
        
        for(int end = start+1; end <= s.Length; end++){
            bool firstPart = map.Contains(s.Substring(start, end-start));
            int secondPart = Helper(s, map, end, dp);
            
            if(firstPart && secondPart == 1){
                dp[start] = 1;
                return 1;
            }
        }
        
        dp[start] = 0;
        return -1;
    }
}