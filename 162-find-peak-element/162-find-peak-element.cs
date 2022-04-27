public class Solution {
    public int FindPeakElement(int[] nums) {
        int l = 0, r = nums.Length-1;
        
        while(l < r){
            int mid = l + (r-l)/2;
            
            if(nums[mid] < nums[mid+1]){
                l = mid+1;
            }
            else{
                r = mid;
            }
        }
        
        return l;
    }
}