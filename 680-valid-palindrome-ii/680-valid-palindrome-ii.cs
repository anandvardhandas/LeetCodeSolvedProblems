public class Solution {
    public bool ValidPalindrome(string s) {
        int len = s.Length;
        
        int i = 0, j = len-1;
        int count = 0;
        while(i <= j){
            while(i <= j && s[i] == s[j]){
                i++;
                j--;
            }
            
            if(i <= j && s[i] != s[j]){
                count++;
                j--;
            }
        }
        
        i = 0; 
        j = len-1;
        int countr = 0;
        while(i <= j){
            while(i <= j && s[i] == s[j]){
                i++;
                j--;
            }
            
            if(i <= j && s[i] != s[j]){
                countr++;
                i++;
            }
        }
        
        if(count <= 1 || countr <= 1)
            return true;
        
        return false;
    }
}