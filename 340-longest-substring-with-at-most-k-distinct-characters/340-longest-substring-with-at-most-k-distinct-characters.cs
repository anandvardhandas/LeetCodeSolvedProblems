public class Solution {
    public int LengthOfLongestSubstringKDistinct(string s, int k) {
        if(k == 0)
            return 0;
        
        int len = s.Length;
        int max = 0;
        
        Dictionary<char,int> map = new Dictionary<char,int>();
        foreach(char c in s){
            if(!map.ContainsKey(c)){
                map.Add(c,0);
            }
        }
        
        int low = 0, hi = 0;
        while(hi < len){
            if(map[s[hi]] == 0){
                k--;
            }
             
            while(k < 0){
                map[s[low]]--;
                if(map[s[low]] == 0){
                    k++;
                }
                
                low++;
            }
            
            max = Math.Max(max, hi-low+1);
            map[s[hi]]++;
            hi++;
        }
        
        return max;
    }
}