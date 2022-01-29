public class Solution {
    public IList<IList<string>> GroupStrings(string[] strings) {
        IList<IList<string>> result = new List<IList<string>>();
        
        Dictionary<string,List<string>> map = new Dictionary<string,List<string>>();
        
        foreach(string str in strings){
            StringBuilder key = new StringBuilder(str.Length);
            key.Append("-");
            for(int i = 1; i < str.Length; i++){
                int diff = str[i]-str[i-1];
                if(diff < 0){
                    diff = 26+diff;
                }
                
                key.Append(diff.ToString());
                key.Append("-");
            }
        
            if(map.ContainsKey(key.ToString())){
                map[key.ToString()].Add(str);
            }
            else{
                map.Add(key.ToString(), new List<string>() { str });
            }
        }
        
        foreach(var item in map){
            result.Add(item.Value);
        }
        
        
        return result;
    }
}