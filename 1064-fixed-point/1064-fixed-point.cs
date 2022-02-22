public class Solution {
    public int FixedPoint(int[] arr) {
        int low = 0, hi = arr.Length-1;
        
        while(low <= hi){
            int mid = low + (hi-low)/2;
            if(mid > arr[mid]){
                low = mid+1;
            }
            else{
                hi = mid-1;
            }
        }
        
        if(low < 0 || low >= arr.Length || arr[low] != low)
            return -1;
        
        return low;
    }
}