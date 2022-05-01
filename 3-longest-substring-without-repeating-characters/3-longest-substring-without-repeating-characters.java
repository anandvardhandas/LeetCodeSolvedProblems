class Solution {
    public int lengthOfLongestSubstring(String s) {
        int len = s.length();
        int max = 0;
        
        Map<Character,Integer> map = new HashMap<>();
        //aabccbb
        int low = 0, hi = 0;
        while(hi < len){
            if(!map.containsKey(s.charAt(hi))){
                map.put(s.charAt(hi), hi);
            }
            else{
                int lastIndex = map.get(s.charAt(hi));
                System.out.println(lastIndex);
                while(low <= lastIndex){
                    map.remove(s.charAt(low));
                    low++;
                }
                
                low = lastIndex+1;
                map.put(s.charAt(hi), hi);
            }
            
            max = Math.max(max, hi-low+1);
            hi++;
        }
        
        return max;
    }
}