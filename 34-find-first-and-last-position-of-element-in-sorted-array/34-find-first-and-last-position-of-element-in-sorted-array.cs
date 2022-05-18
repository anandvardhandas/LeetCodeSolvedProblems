public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int len = nums.Length;
        if(len == 0){
            return new int[] { -1, -1 };
        }
        //finding first position
        
        int first = Helper(nums, target, true);
        if(first == -1){
            return new int[] { -1, -1 };
        }
        
        //finding the last position
        int last = Helper(nums, target, false);
        return new int[] { first, last };
    }
    
    private int Helper(int[] nums, int target, bool first){
        int ans = -1;
        int low = 0, hi = nums.Length-1;
        while(low <= hi){
            int mid = low + (hi-low)/2;
            if(nums[mid] < target){
                low = mid+1;
            }
            else if(nums[mid] > target){
                hi = mid-1;
            }
            else{
                ans = mid;
                if(first)
                    hi = mid-1;
                else
                    low = mid+1;
            }
        }
        
        return ans;
    }
}