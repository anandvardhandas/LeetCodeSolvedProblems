public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        if(magazine.Length < ransomNote.Length)
            return false;
        
        int[] map = new int[26];
        foreach(char c in magazine){
            map[c-'a']++;
        }
        
        int[] map2 = new int[26];
        foreach(char c in ransomNote){
            map2[c-'a']++;
        }
        
        for(int i = 0; i < 26; i++){
            if(map2[i] > map[i]){
                return false;
            }
        }
        
        return true;
    }
}