public class Solution {
    public int Search(int[] nums, int target) {
        int len = nums.Length;
        
        if(len == 1){
            if(nums[0] == target)
                return 0;
            else
                return -1;
        }
        
        int low = 0, hi = len-1;
        int pivot = -1;
        while(true){
            int mid = low+(hi-low)/2;
            
            if(mid > 0 && nums[mid] < nums[mid-1]){
                pivot = mid-1;
                break;
            }
            else if(mid < len-1 && nums[mid] > nums[mid+1]){
                pivot = mid;
                break;
            }
            
            if(nums[mid] < nums[low]){
                hi = mid;
            }
            else if(nums[mid] > nums[hi]){
                low = mid;
            }
            else{
                return BinarySearch(nums, 0, len-1, target);
            }
        }
        
        if(target >= nums[0] && target <= nums[pivot]){
            return BinarySearch(nums, 0, pivot, target);
        }
        else{
            return BinarySearch(nums, pivot+1, len-1, target);
        }
    }
    
    private int BinarySearch(int[] nums, int low, int hi, int target){
        while(low <= hi){
            int mid = low + (hi-low)/2;
            if(nums[mid] == target)
                return mid;
            else if(nums[mid] < target)
                low = mid+1;
            else
                hi = mid-1;
        }
        
        return -1;
    }
}