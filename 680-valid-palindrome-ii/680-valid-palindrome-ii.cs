public class Solution {
    public bool ValidPalindrome(string s) {
        int len = s.Length;
        int l = 0, r = len-1;
        
        int passl = 0;
        while(l<r){
            if(s[l] == s[r]){
                l++;
                r--;
            }
            else{
                passl++;
                l++;
            }
        }
        
        l = 0;
        r = len-1;
        int passr = 0;
        while(l<r){
            if(s[l] == s[r]){
                l++;
                r--;
            }
            else{
                passr++;
                r--;
            }
        }
        
        if(passl < 2 || passr < 2)
            return true;
        
        return false;
    }
}

// rgacecar
// rabcar