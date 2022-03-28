public class Solution {
    public bool Search(int[] nums, int target) {
        
        int len = nums.Length;
        int low = 0, hi = len-1;
        while(low <= hi){
            int mid = low + (hi-low)/2;
            
            if(nums[mid] == target)
                return true;
            else if((nums[mid] == nums[low]) && (nums[mid] == nums[hi])){
                low++;
                hi--;
            }
            else if(nums[mid] >= nums[low]){
                if(target >= nums[low] && target < nums[mid]){
                    hi = mid-1;
                }
                else{
                    low = mid+1;
                }
            }
            else{
                if(target > nums[mid] && target <= nums[hi]){
                    low = mid+1;
                }
                else{
                    hi = mid-1;
                }
            }
        }
        
        return false;
    }
}