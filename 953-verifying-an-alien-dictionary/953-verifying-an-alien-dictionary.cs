public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        int[] map = new int[26];
        for(int i = 0; i < order.Length; i++){
            map[order[i]-97] = i;
        }
        
        for(int i = 0; i < words.Length-1; i++){
            if(!InOrder(map, words[i], words[i+1])){
                return false;
            }
        }
        
        return true;
    }
    
    private bool InOrder(int[] map, string word1, string word2){
        int i = 0, j = 0;
        
        while(i < word1.Length && j < word2.Length){
            char c1 = word1[i];
            char c2 = word2[j];
            
            if(c1 == c2){
                i++;
                j++;
            }
            else{
                if(map[c1-97] > map[c2-97]){
                    return false;
                }
                else{
                    return true;
                }
            }
        }
        
        if(i < word1.Length)
            return false;
        
        return true;
    }
}