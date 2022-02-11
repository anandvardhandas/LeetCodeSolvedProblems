class Solution {
    public boolean checkInclusion(String s1, String s2) {
        int len1 = s1.length();
        int len2 = s2.length();
        
        if(len2 < len1)
            return false;
        
        int[] map1 = new int[26];
        int[] map2 = new int[26];
        
        for(int i = 0; i < len1; i++){
            map1[s1.charAt(i)-97]++;
        }
        
        int matchCount = 0;
        int i = 0;
        for(; i < len1; i++){
            if(map1[s2.charAt(i)-97] > 0){
                map2[s2.charAt(i)-97]++;
                if(map2[s2.charAt(i)-97] <= map1[s2.charAt(i)-97]){
                    matchCount++;
                }
            }
        }
        
        if(matchCount == len1)
            return true;
        
        int low = 0, hi = len1-1;
        //sliding window now
        
        while(hi < len2){
            if(map1[s2.charAt(low)-97] > 0){
                map2[s2.charAt(low)-97]--;
                if(map2[s2.charAt(low)-97] < map1[s2.charAt(low)-97])
                    matchCount--;
            }
            
            low++;
            
            hi++;
            if(hi < len2 && map1[s2.charAt(hi)-97] > 0){
                map2[s2.charAt(hi)-97]++;
                if(map2[s2.charAt(hi)-97] <= map1[s2.charAt(hi)-97]){
                    matchCount++;
                }
            }
            
            if(matchCount == len1)
                return true;
        }
        
        return false;
    }
}