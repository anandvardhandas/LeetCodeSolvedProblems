public class Solution {
    public int NumKLenSubstrNoRepeats(string s, int k) {
        int len = s.Length;
        if(k > len)
            return 0;
        
        int result = 0;
        int[] map = new int[26];
        
        int uniquelen = 0;
        for(int i = 0; i < k; i++){
            if(map[s[i]-97] == 0)
                uniquelen++;
            
            map[s[i]-97]++;
        }
        
        if(uniquelen == k)
            result++;
        
        int low = 0, hi = k-1;
        while(hi < len-1){
            map[s[low]-97]--;
            if(map[s[low]-97] == 0)
                uniquelen--;
            
            low++;
            hi++;
            
            map[s[hi]-97]++;
            
            if(map[s[hi]-97] == 1)
                uniquelen++;
            
            if(uniquelen == k)
                result++;
        }
        
        return result;
    }
}