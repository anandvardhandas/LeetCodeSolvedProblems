public class Solution {
    public int MinSteps(string s, string t) {
        int[] smap = new int[26];
        int[] tmap = new int[26];
        
        foreach(char c in s){
            smap[c-97]++;
        }
        
        foreach(char c in t){
            tmap[c-97]++;
        }
        
        int result = 0;
        
        for(int i = 0; i < 26; i++){
            result += Math.Abs(smap[i] - tmap[i]);
        }
        
        return result;
    }
}