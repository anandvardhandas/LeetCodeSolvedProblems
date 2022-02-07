public class Solution {
    public char FindTheDifference(string s, string t) {
        int[] map = new int[26];
        for(int i = 0; i < t.Length; i++){
            map[t[i]-97]++;
        }
        
        for(int i = 0; i < s.Length; i++){
            map[s[i]-97]--;
        }
        
        for(int i = 0; i < 26; i++){
            if(map[i] > 0){
                return Convert.ToChar(97+i);
            }
        }
        
        return ' ';
        
    }
}