public class Solution {
    public int CountBinarySubstrings(string s) {
        int len = s.Length;
        int[] groups = new int[len];
        groups[0] = 1;
        
        int index = 0;
        
        for(int i = 1; i < len; i++){
            if(s[i] == s[i-1]){
                groups[index]++;
            }
            else{
                index++;
                groups[index] = 1;
            }
        }
        
        int result = 0;
        
        for(int i = 1; i < len; i++){
            result += Math.Min(groups[i], groups[i-1]);
        }
        
        return result;
    }
}