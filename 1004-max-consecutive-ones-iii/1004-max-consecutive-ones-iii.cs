public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int len = nums.Length;
        
        int low = 0, hi = 0;
        int max = int.MinValue;
        
        int curr = 0;
        while(hi < len){
            if(nums[hi] == 0){
                k--;
            }
            
            while(k < 0){
                if(nums[low] == 0){
                    k++;
                }
                
                low++;
            }
            max = Math.Max(max, hi-low+1);
            hi++;
        }
        
        return max;
    }
}