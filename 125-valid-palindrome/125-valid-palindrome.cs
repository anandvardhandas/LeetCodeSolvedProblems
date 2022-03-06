public class Solution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        StringBuilder sb = new StringBuilder();
        foreach(char c in s){
            if((c >= 97 && c <= 122) || (c >= 48 && c <= 57)){
                sb.Append(c.ToString());
            }
        }
        
        s = sb.ToString();
        
        int l = 0, r = s.Length-1;
        while(l < r){
            if(s[l] != s[r])
                return false;
            
            l++;
            r--;
        }
        
        return true;
    }
}