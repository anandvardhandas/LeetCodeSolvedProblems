class Solution {
    public int firstUniqChar(String s) {
        int[] map = new int[26];
        char[] input = s.toCharArray();
        for(char c : input){
            map[c-97]++;
        }
        
        for(int i = 0; i < s.length(); i++){
            if(map[input[i]-97] == 1)
                return i;
        }
        
        return -1;
    }
}