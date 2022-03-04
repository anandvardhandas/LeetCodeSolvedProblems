public class Solution {
    public int MinAddToMakeValid(string s) {
        int open = 0, close = 0;
        int total = 0;
        int len = s.Length;
        
        for(int i = 0; i < len; i++){
            if(s[i] == '('){
                open++;
            }
            else{
                close++;
            }
            
            if(close > open){
                total += close-open;
                close = open;
            }
        }
        
        if(open > close){
            total += open-close;
        }
        
        return total;
    }
}