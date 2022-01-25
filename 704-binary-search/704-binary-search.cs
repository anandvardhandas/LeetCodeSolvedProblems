public class Solution {
    public int Search(int[] nums, int target) {
        int len = nums.Length;
        int l = 0, r = len-1;
        while(l <= r){
            int mid = l + (r-l)/2;
            if(nums[mid] == target)
                return mid;
            else if(nums[mid] < target){
                l = mid+1;
            }
            else{
                r = mid-1;
            }
        }
        
        return -1;
    }
}