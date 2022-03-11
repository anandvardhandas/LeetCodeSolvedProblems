public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
        int slen = s.Length;
        int plen = p.Length;
        IList<int> result = new List<int>();
        if(slen < plen)
            return result;
        
        int[] map2 = new int[26];
        int[] map = new int[26];
        foreach(char c in p){
            map[c-97]++;
        }
        
        int len = 0;
        //sliding window
        for(int i = 0; i < plen; i++){
            int index = s[i]-97;
            if(map[index] > 0){
                map2[index]++;
                if(map2[index] <= map[index])
                    len++;
            }
        }
        
        if(len == plen)
            result.Add(0);
        
        int l = 0, r = plen-1;
        while(r < slen-1){
            //shift left by 1
            int index = s[l]-97;
            if(map[index] > 0){
                map2[index]--;
                if(map2[index] < map[index]){
                    len--;
                }
            }
            
            l++;
            
            //shift right by 1
            r++;
            index = s[r]-97;
            if(map[index] > 0){
                map2[index]++;
                if(map2[index] <= map[index]){
                    len++;
                }
            }
            
            if(len == plen)
                result.Add(l);
            
        }
        
        
        return result;
    }
}