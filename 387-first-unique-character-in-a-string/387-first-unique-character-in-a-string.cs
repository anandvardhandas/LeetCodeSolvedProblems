public class Solution {
    public int FirstUniqChar(string s) {
        int[] map = new int[26];
        foreach(char c in s){
            map[c-97]++;
        }
        
        for(int i = 0; i < s.Length; i++){
            if(map[s[i]-97] == 1)
                return i;
        }
        
        return -1;
    }
}