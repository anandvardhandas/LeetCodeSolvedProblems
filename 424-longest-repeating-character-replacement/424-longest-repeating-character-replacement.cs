public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char,int> map = new Dictionary<char,int>();
        
        int len = s.Length;
        int maxlen = 0;
        int low = 0, hi = 0;
        int maxfreq = 0;
        while(hi < len){
            if(map.ContainsKey(s[hi]))
                map[s[hi]]++;
            else
                map.Add(s[hi], 1);
            
            maxfreq = Math.Max(maxfreq, map[s[hi]]);
            
            while((hi-low+1) - maxfreq > k){
                map[s[low]]--;
                
                low++;
            }
            
            maxlen = Math.Max(maxlen, hi-low+1);
            hi++;
        }
        
        return maxlen;
    }
}