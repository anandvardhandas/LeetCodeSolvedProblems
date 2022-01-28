public class Solution {
    public int FindSpecialInteger(int[] arr) {
        int len = arr.Length;
        
        int low = 0, hi = 0;
        while(hi < len){
            while(hi < len && arr[hi] == arr[low]){
                hi++;
            }
            
            if(hi-low > len/4)
                return arr[low];
            
            low = hi;
        }
        
        return -1;
    }
}