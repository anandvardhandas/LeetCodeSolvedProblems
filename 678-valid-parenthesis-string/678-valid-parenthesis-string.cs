public class Solution {
    public bool CheckValidString(string s) {
        //greedy
        
        int openbracketmin = 0, openbracketmax = 0;
        foreach(char c in s){
            if(c == '('){
                openbracketmin++;
                openbracketmax++;
            }
            else if(c == ')'){
                openbracketmin--;
                openbracketmax--;
            }
            else{
                openbracketmin--;
                openbracketmax++;
            }
            
            if(openbracketmax < 0)
                return false;
            
            if(openbracketmin < 0)
                openbracketmin = 0;
        }
        
        if(openbracketmin == 0)
            return true;
        
        return false;
    }
    
    
}