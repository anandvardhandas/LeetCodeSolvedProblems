public class Solution {
    public int MaxProduct(string[] words) {
        
        List<int[]> list = new List<int[]>();
        foreach(string word in words){
            int[] map = new int[26];
            foreach(char c in word){
                map[c-'a']++;
            }
            
            list.Add(map);
        }
        
        int result = 0;
        for(int i = 0; i < words.Length; i++){
            for(int j = i+1; j < words.Length; j++){
                if(i != j){
                    int[] map1 = list[i];
                    int[] map2 = list[j];
                    
                    bool same = false;
                    for(int k = 0; k < 26; k++){
                        if(map1[k] > 0 && map2[k] > 0){
                            same = true;
                            break;
                        }
                    }
                    
                    if(!same){
                        result = Math.Max(result, words[i].Length * words[j].Length);
                    }
                }
            }
        }
        
        return result;
    }
}