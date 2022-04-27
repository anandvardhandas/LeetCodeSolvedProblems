public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums == null || nums.Length == 0)
            return 0;
        int l = 0, r = 0;
        for(; r < nums.Length - 1; r++)
        {
            if(nums[r] != nums[r+1])
            {
                l++;
                nums[l]= nums[r+1];
            }
        }
        
        return l+1;
    }
}