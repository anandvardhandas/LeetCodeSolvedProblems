public class Solution {
    public int CountElements(int[] nums) {
        if(nums.Length == 1)
            return 0;
        
        int max = int.MinValue, min = int.MaxValue;
        for(int i = 0; i < nums.Length; i++){
            max = Math.Max(max, nums[i]);
            min = Math.Min(min, nums[i]);
        }
        
        if(max == min)
            return 0;
        
        int maxcount = 0, mincount = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == max)
                maxcount++;
            
            if(nums[i] == min)
                mincount++;
        }
        
        return nums.Length - maxcount - mincount;
    }
}