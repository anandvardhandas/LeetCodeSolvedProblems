public class Solution {
    public int CountWords(string[] words1, string[] words2) {
        Dictionary<string,int> map = new Dictionary<string,int>();
        foreach(string word in words1){
            if(!map.ContainsKey(word)){
                map.Add(word, 1);
            }
            else{
                map[word] = 100;
            }
        }
        
        foreach(string word in words2){
            if(map.ContainsKey(word)){
                map[word]++;
            }
        }
        
        int result = 0;
        foreach(var item in map){
            if(item.Value == 2)
                result++;
        }
        
        return result;
    }
}