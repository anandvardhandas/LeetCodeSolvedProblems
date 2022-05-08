public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        IList<IList<string>> result = new List<IList<string>>();
        Dictionary<string,List<string>> hashmap = new Dictionary<string,List<string>>();
        foreach(string str in strs){
            int[] map = new int[26];
            foreach(char c in str){
                map[c-'a']++;
            }
            
            StringBuilder sb = new StringBuilder();
            for(char c = 'a'; c <= 'z'; c++){
                if(map[c-'a'] > 0){
                    sb.Append($"{map[c-'a']}{c}");
                }
            }
            
            string key = sb.ToString();
            if(hashmap.ContainsKey(key)){
                hashmap[key].Add(str);
            }
            else{
                hashmap.Add(key, new List<string>() { str });
            }
        }
        
        foreach(var item in hashmap){
            result.Add(item.Value);
        }
        
        return result;
    }
}