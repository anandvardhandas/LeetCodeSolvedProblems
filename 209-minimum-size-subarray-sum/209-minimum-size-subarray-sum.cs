public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int len = nums.Length;
        int result = int.MaxValue;
        
        for(int i = 1; i < len; i++){
            nums[i] += nums[i-1];
        }
        
        int low = 0, hi = 0;
        int j = 0;
        while(j < len && nums[j] < target){
            j++;
        }
        
        if(j == len)
            return 0;
        
        hi = j;
        result = Math.Min(result, hi-low+1);
        
        while(hi < len){
            while(nums[hi]-nums[low] >= target){
                result = Math.Min(result, hi-low+1);
                low++;
            }
            
            result = Math.Min(result, hi-low+1);
            
            while(hi < len && nums[hi] - nums[low] < target){
                hi++;
            }
            
            result = Math.Min(result, hi-low+1);
        }
        
        return result;
    }
}