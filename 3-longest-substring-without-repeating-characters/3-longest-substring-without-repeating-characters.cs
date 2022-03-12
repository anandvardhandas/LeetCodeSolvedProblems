public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s == null | s.Length == 0)
            return 0;
        Dictionary<char,int> map = new Dictionary<char,int>();
        
        int maxlen = 0, clen = 0;
        int start = 0;
        for(int i = 0; i < s.Length; i++){
            if(!map.ContainsKey(s[i])){
                map.Add(s[i], i);
                clen = i-start+1;
                maxlen = Math.Max(maxlen, clen);
            }
            else{
                int lastindex = map[s[i]];
                
                while(start <= lastindex){
                    if(map.ContainsKey(s[start])){
                        map.Remove(s[start]);
                    }
                    
                    start++;
                }
                
                map.Add(s[i],i);
                
                clen = i-start+1;
                maxlen = Math.Max(maxlen, clen);
            }
        }
        
        return maxlen;
    }
}