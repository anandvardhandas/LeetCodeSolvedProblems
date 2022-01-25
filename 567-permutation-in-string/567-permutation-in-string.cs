public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int len1 = s1.Length, len2 = s2.Length;
        if(len1 > len2)
            return false;
        
        int[] map1 = new int[26];
        for(int i = 0; i < len1; i++){
            map1[s1[i]-97]++;
        }
        
        int[] map2 = new int[26];
        int matchingCount = 0;
        for(int i = 0; i < len1; i++){
            char c = s2[i];
            if(map1[c-97] > 0){
                if(map2[c-97] < map1[c-97]){
                    matchingCount++;
                    if(matchingCount == len1)
                        return true;
                }
                
                 map2[c-97]++;
            }
        }
        
        //sliding window
        int low = 0, hi = len1-1;
        while(hi < len2-1){
            char c = s2[low];
            if(map1[c-97] > 0){
                if(map2[c-97] <= map1[c-97])
                    matchingCount--;
                
                map2[c-97]--;
                
            }
            
            low++;
            
            hi++;
            c = s2[hi];
            if(map1[c-97] > 0){
                if(map2[c-97] < map1[c-97]){
                    matchingCount++;
                }
                
                 map2[c-97]++;
            }
            
            if(matchingCount == len1)
                return true;
            
        }
        
        return matchingCount == len1;
    }
}