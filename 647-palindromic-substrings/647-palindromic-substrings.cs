public class Solution {
    public int CountSubstrings(string s) {
        
        int total = Calculate(s);
        return total;
        
    }
    
    private int Calculate(string s){
        int len = s.Length;
        
        int[,] dp = new int[len+1,len+1];
        
        int total = 0;
        for(int i = len-1; i >= 0; i--){
            for(int j = i; j < len; j++){
                if(j-i <= 1){
                    if(j == i){
                        dp[i,j] = 1;
                        total++;
                    }
                    else if(s[j] == s[i]){
                        dp[i,j] = 1;
                        total++;
                    }
                }
                else{
                    if(s[j] == s[i]){
                        if(dp[i+1,j-1] == 1){
                            dp[i,j] = 1;
                            total++;
                        }
                    }
                }
            }
        }
        
        return total;
    }
}