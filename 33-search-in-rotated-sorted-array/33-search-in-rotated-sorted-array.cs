public class Solution {
    public int Search(int[] nums, int target) {
        int len = nums.Length;
        int low = 0, hi = len-1;
        
        while(low <= hi){
            int mid = low + (hi-low)/2;
            if(nums[mid] == target)
                return mid;
            else if(nums[mid] >= nums[low]){
                if(target >= nums[low] && target < nums[mid]){
                    hi = mid-1;
                }
                else{
                    low = mid+1;
                }
            }
            else{
                if(target <= nums[hi] && target > nums[mid]){
                    low = mid+1;
                }
                else{
                    hi = mid-1;
                }
            }
        }
        
        return -1;
    }
}