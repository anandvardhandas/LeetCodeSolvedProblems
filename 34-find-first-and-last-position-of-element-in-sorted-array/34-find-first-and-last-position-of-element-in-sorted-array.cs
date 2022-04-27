public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        if(nums == null || nums.Length == 0){
            return new int[] { -1, -1 };
        }
        
        int len = nums.Length;
        
        //binary search
        int left = FindLeftMostIndex(nums, 0, len-1, target);
        if(left == -1)
            return new int[] { -1, -1 };
        int right = FindRightMostIndex(nums, 0, len-1, target);
        if(right != -1){
            return new int[] { left, right };
        }
        
        return new int[] { -1, -1 };
    }
    
    private int FindLeftMostIndex(int[] nums, int l, int r, int target){
        int index = -1;
        while(l<=r){
            int mid = l + (r-l)/2;
            if(nums[mid] >= target){
                if(nums[mid] == target){
                    index = mid;
                }
                
                r = mid-1;
            }
            else{
                l = mid+1;
            }
        }
        
        
        return index;
    }
    
    private int FindRightMostIndex(int[] nums, int l, int r, int target){
        int index = -1;
        while(l<=r){
            int mid = l + (r-l)/2;
            if(nums[mid] <= target){
                if(nums[mid] == target){
                    index = mid;
                }
                
                l = mid+1;
            }
            else{
                r = mid-1;
            }
        }
        
        return index;
    }
}