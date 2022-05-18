public class Solution {
    public int SpecialArray(int[] nums) {
        int len = nums.Length;
        
        Array.Sort(nums);
        
        int low = 0, hi = nums[len-1];
        while(low <= hi){
            int mid = low + (hi-low)/2;
            int pos = Helper(nums, mid);
            int greater = len-pos-1;
            if(pos == 0){
                greater++;
            }
            if(greater == mid){
                return mid;
            }
            else if(greater > mid){
                low = mid+1;
            }
            else{
                hi = mid-1;
            }
        }
        
        return -1;
        
    }
    //[0,0,3,4,4]
    private int Helper(int[] nums, int target){
        int len = nums.Length-1;
        int low = 0, hi = len-1;
        int result = 0;
        while(low <= hi){
            int mid = low + (hi-low)/2;
            if(nums[mid] >= target){
                hi = mid-1;
            }
            else{
                result = mid;
                low = mid+1;
            }
        }
        
        return result;
    }
}