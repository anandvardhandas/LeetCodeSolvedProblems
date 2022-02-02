public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        int slen = s.Length, plen = p.Length;
        int[] smap = new int[26];
        int[] pmap = new int[26];
        IList<int> result = new List<int>();
        if(plen > slen)
            return result;
        
        foreach(char c in p){
            pmap[c-97]++;
        }
        
        int matchcount = 0;
        for(int i = 0; i < plen; i++){
            char c = s[i];
            if(pmap[c-97] > 0){
                if(smap[c-97] < pmap[c-97]){
                    matchcount++;
                    if(matchcount == plen){
                        result.Add(0);
                    }
                }
                
                smap[c-97]++;
            }
        }
        
        int low = 0, hi = plen-1;
        while(hi < slen-1 && low < slen-1){
            if(pmap[s[low]-97] > 0){
                if(smap[s[low]-97] <= pmap[s[low]-97]){
                    matchcount--;
                }
                smap[s[low]-97]--;
            }
            
            low++;
            hi++;
            
            if(pmap[s[hi]-97] > 0){
                if(smap[s[hi]-97] < pmap[s[hi]-97]){
                    matchcount++;
                }
                
                smap[s[hi]-97]++;
            }
            
            if(matchcount == plen){
                result.Add(low);
            }
        }
        
        return result;
    }
}