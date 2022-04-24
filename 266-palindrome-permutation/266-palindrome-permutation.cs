public class Solution {
    public bool CanPermutePalindrome(string s) {
        int[] map = new int[26];
        
        foreach(char c in s){
            map[c-97]++;
        }
        
        int odd = 0;
        for(int i = 0; i < 26; i++){
            if(map[i] > 0 && map[i]%2 == 1){
                odd++;
            }
            
            if(odd > 1)
                return false;
        }
        
        return true;
    }
}