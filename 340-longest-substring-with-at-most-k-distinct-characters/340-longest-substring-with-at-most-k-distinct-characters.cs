public class Solution {
    public int LengthOfLongestSubstringKDistinct(string s, int k) {
        if(k == 0)
            return 0;
        
        int len = s.Length;
        int max = 0;
        
        Dictionary<char,int> map = new Dictionary<char,int>();
        
        int low = 0, hi = 0;
        while(hi < len){
            if(!map.ContainsKey(s[hi])){
                k--;
            }
             
            while(k < 0){
                map[s[low]]--;
                if(map[s[low]] == 0){
                    k++;
                    map.Remove(s[low]);
                }
                
                low++;
            }
            
            max = Math.Max(max, hi-low+1);
            if(!map.ContainsKey(s[hi])){
                map.Add(s[hi], 1);
            }
            else
                map[s[hi]]++;
            
            hi++;
        }
        
        return max;
    }
}