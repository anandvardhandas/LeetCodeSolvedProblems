public class Solution {
    public bool CheckRecord(string s) {
        int abs = 0, late = 0;
        for(int i = 0; i < s.Length; i++){
            if(s[i] == 'A'){
                abs++;
                late = 0;
            }
            else if(s[i] == 'L'){
                late++;
            }
            else{
                late = 0;
            }
            
            if(abs > 1 || late > 2)
                return false;
        }
        
        return true;
    }
}