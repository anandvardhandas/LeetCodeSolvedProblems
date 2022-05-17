public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int len = nums.Length;
        int low = 0, hi = len-1;
        
        while(low <= hi){
            int mid = low + (hi-low)/2;
            
            if(nums[mid] == target){
                return mid;
            }
            else if(nums[mid] > target){
                hi = mid-1;
            }
            else{
                low = mid+1;
            }
        }
        
        return low;
    }
}