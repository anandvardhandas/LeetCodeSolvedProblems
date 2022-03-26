public class Solution {
    public bool CheckRecord(string s) {
        int len = s.Length;
        int abs = 0, late = 0;
        for(int i = 0; i < len; i++){
            if(s[i] == 'P'){
                late = 0;
            }
            else if(s[i] == 'A'){
                abs++;
                late = 0;
                if(abs > 1)
                    return false;
            }
            else if(s[i] == 'L'){
                late++;
                if(late == 3)
                    return false;
            }
        }
        
        return true;
    }
}