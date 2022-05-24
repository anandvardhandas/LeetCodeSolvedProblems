public class Solution {
    public int LongestValidParentheses(string s) {
        int len = s.Length;
        if(len == 0)
            return 0;
        
        int open = 0, close = 0;
        
        int maxlen = 0;
        
        for(int i = 0; i < len; i++){
            if(s[i] == '('){
                open++;
            }
            else{
                close++;
                if(open == close){
                    maxlen = Math.Max(maxlen, 2*close);
                }
                else if(close > open){
                    open = 0;
                    close = 0;
                }
            }
        }
        
        open = 0; close = 0;
        for(int i = len-1; i >= 0; i--){
            if(s[i] == ')'){
                close++;
            }
            else{
                open++;
                if(open == close){
                    maxlen = Math.Max(maxlen, 2*close);
                }
                else if(open > close){
                    open = 0;
                    close = 0;
                }
            }
        }
        
        return maxlen;
    }
}