public class Solution {
    public int MinDistance(string word1, string word2) {
        int m = word1.Length, n = word2.Length;
        
        if(m == 0)
            return n;
        if(n == 0)
            return m;
        
        int[,] dp = new int[m,n];
        for(int i = 0; i < m; i++){
            for(int j = 0; j < n; j++){
                dp[i,j] = -1;
            }
        }
        
        return Helper(word1, word2, dp, 0, 0);
    }
    
    private int Helper(string word1, string word2, int[,] dp, int i, int j){
        if(i == word1.Length)
            return word2.Length-j;
        
        if(j == word2.Length)
            return word1.Length-i;
        
        if(dp[i,j] != -1){
            return dp[i,j];
        }
        
        int result = int.MaxValue;
        if(word1[i] == word2[j]){
            result =  Math.Min(result, Helper(word1, word2, dp, i+1,j+1));
        }
        else{
            //insert
            int dist1 = 1 + Helper(word1, word2, dp, i, j+1);
            
            //delete
            int dist2 = 1 + Helper(word1, word2, dp, i+1, j);
            
            //replace
            int dist3 = 1 + Helper(word1, word2, dp, i+1, j+1);
            
            result = Math.Min(dist1, Math.Min(dist2, dist3));
        }
        
        dp[i,j] = result;
        return result;
    }
}