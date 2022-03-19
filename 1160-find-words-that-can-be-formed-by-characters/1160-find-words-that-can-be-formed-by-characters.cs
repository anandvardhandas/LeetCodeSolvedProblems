public class Solution {
    public int CountCharacters(string[] words, string chars) {
        int[] map = new int[26];
        foreach(char c in chars){
            map[c-97]++;
        }
        
        int result = 0;
        
        foreach(string word in words){
            int[] map2 = new int[26];
            foreach(char c in word){
                map2[c-97]++;
            }
            
            bool isMatching = true;
            for(int i = 0; i < 26; i++){
                if(map2[i] > 0){
                    if(map2[i] > map[i]){
                        isMatching = false;
                        break;
                    }
                }
            }
            
            if(isMatching)
                result += word.Length;
        }
        
        
        return result;
    }
}