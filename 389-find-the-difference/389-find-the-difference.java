class Solution {
    public char findTheDifference(String s, String t) {
        int[] map = new int[26];
        for(int i = 0; i < t.length(); i++){
            map[t.charAt(i)-97]++;
        }
        
        for(int i = 0; i < s.length(); i++){
            map[s.charAt(i)-97]--;
        }
        
        for(int i = 0; i < 26; i++){
            if(map[i] > 0){
                return Character.toChars(97+i)[0];
            }
        }
        
        return ' ';
    }
}