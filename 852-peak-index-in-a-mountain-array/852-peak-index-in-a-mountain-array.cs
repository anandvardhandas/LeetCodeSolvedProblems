public class Solution {
    public int PeakIndexInMountainArray(int[] arr) {
        int len = arr.Length;
        
        int low = 0, hi = len-1;
        while(low <= hi){
            int mid = low+(hi-low)/2;
            if(mid > 0 && mid < len-1 && arr[mid] > arr[mid-1] && arr[mid] > arr[mid+1]){
                return mid;
            }
            else if(mid < len-1 && arr[mid] > arr[mid+1] && mid > 0 && arr[mid] < arr[mid-1]){
                hi = mid-1;
            }
            else{
                low = mid+1;
            }
        }
        
        return low;
    }
}