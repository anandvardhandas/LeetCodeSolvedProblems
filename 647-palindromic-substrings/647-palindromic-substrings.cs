public class Solution {
    public int CountSubstrings(string s) {
        
        int total = 0;
        int len = s.Length;
        for(int i = 0; i < len; i++){
            total += Calculate(s, i, i);
            total += Calculate(s, i, i+1);
        }
        
        return total;
    }
    
    private int Calculate(string s, int low, int hi){
        int len = s.Length;
        
        int total = 0;
        
        while(low >= 0 && hi < len){
            if(s[low] == s[hi]){
                total++;
                low--;
                hi++;
            }
            else{
                break;
            }
        }
        
        return total;
    }
}