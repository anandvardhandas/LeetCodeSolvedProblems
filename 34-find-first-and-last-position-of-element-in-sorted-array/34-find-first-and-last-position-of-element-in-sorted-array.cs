public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int len = nums.Length;
        if(len == 0){
            return new int[] { -1, -1 };
        }
        //finding first position
        int low = 0, hi = len-1;
        
        int first = -1;
        while(low <= hi){
            int mid = low + (hi-low)/2;
            if(nums[mid] < target){
                low = mid+1;
            }
            else if(nums[mid] > target){
                hi = mid-1;
            }
            else{
                first = mid;
                hi = mid-1;
            }
        }
        
        if(first == -1){
            return new int[] { -1, -1 };
        }
        
        //finding the last position
        int last = -1;
        low = 0; hi = len-1;
        while(low <= hi){
            int mid = low + (hi-low)/2;
            if(nums[mid] < target){
                low = mid+1;
            }
            else if(nums[mid] > target){
                hi = mid-1;
            }
            else{
                last = mid;
                low = mid+1;
            }
        }
        
        return new int[] { first, last };
    }
}