public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(s.Length == 0 || (s.Length == 0 && t.Length == 0))
            return true;
        
        if(s.Length > t.Length || t.Length == 0)
            return false;
        
        int i = 0, j = 0;
        int count = 0;
        while(i < s.Length && j < t.Length){
            while(j < t.Length && s[i] != t[j]){
                j++;
            }
            
            if(i < s.Length && j < t.Length && s[i] == t[j]){
                i++;
                j++;
            }
        }
        
        return i == s.Length;
    }
}