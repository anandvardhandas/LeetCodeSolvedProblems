public class Solution {
    public bool IsNumber(string s) {
       s = s.ToLower();
       if(s.Contains('e')){
           string[] parts = s.Split('e');
           if(parts.Length > 2)
               return false;
           bool isdecimal = IsDecimal(parts[0]);
           bool isinteger = IsInteger(parts[1]);
           return isdecimal && isinteger;
       }
        else{
            return IsDecimal(s);
        }
    }
    
    
    private bool IsDecimal(string s){
        int len = s.Length;
        int i = 0;
        if(len == 0){
            return false;
        }
        
        char c = s[i];
        if(c == '+' || c == '-'){
            i++;
            return CheckDots(s.Substring(i, s.Length-i));
        }
        else{
            return CheckDots(s.Substring(i, s.Length-i));
        }
    }
    
    private bool CheckDots(string s){
        int len = s.Length;
         if(len == 0){
            return false;
        }
        
        string[] parts = s.Split('.');
        if(parts.Length > 2)
            return false;
        if(parts.Length == 2 && parts[0] == "" && parts[1] == "")
            return false;
        
        bool left = true;
        if(parts[0] != ""){
            left = CheckDigit(parts[0]);
        }
        
        bool right = true;
        if(parts.Length == 2 && parts[1] != ""){
            right = CheckDigit(parts[1]);
        }
        
        return left && right;
    }
    
    private bool IsInteger(string s){
        int len = s.Length;
        int i = 0;
         if(len == 0){
            return false;
        }
        
        char c = s[i];
        if(c == '+' || c == '-'){
            i++;
            if(i == len)
                return false;
            bool checkdigit = CheckDigit(s.Substring(i, s.Length-i));
            return checkdigit;
        }
        else{
            bool checkdigit = CheckDigit(s.Substring(i, s.Length-i));
            return checkdigit;
        }
    }
    
    
    private bool CheckDigit(string s){
        int i = 0;
        int len = s.Length;
        if(len == 0){
            return false;
        }
        
        while(i < len && Char.IsDigit(s[i])){
            i++;
        }
        
        if(i == len)
            return true;
        
        return false;
    }
}