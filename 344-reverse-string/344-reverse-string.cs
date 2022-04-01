public class Solution {
    public void ReverseString(char[] s) {
        int len = s.Length;
        int low = 0, hi = len-1;
        while(low < hi){
            char temp = s[low];
            s[low] = s[hi];
            s[hi] = temp;
            
            low++;
            hi--;
        }
    }
}