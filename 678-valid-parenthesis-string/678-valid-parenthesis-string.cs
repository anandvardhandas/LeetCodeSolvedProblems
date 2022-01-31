public class Solution {
    public bool CheckValidString(string s) {
        int[,] dp = new int[s.Length+1,s.Length+1];
        for(int i = 0; i < s.Length+1; i++){
            for(int j = 0; j < s.Length+1; j++){
                dp[i,j] = -1;
            }
        }
        
        return Helper(s, 0, 0, dp);
    }
    
    private bool Helper(string s, int index, int openbracketcount, int[,] dp){
        if(index == s.Length){
            if(openbracketcount == 0)
                return true;
            else
                return false;
        }
        
        if(openbracketcount < 0)
            return false;
        
        if(dp[index,openbracketcount] >= 0)
            return dp[index,openbracketcount] == 1;
        
        bool result = false;
        
        if(s[index] == '(')
            result = Helper(s, index+1, openbracketcount+1, dp);
        else if(s[index] == ')')
            result = Helper(s, index+1, openbracketcount-1, dp);
        else{
            result = Helper(s, index+1, openbracketcount, dp) || Helper(s, index+1, openbracketcount+1, dp) || Helper(s, index+1, openbracketcount-1, dp);
        }
        
        dp[index,openbracketcount] = result ? 1 : 0;
        return result;
    }
}