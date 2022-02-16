public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int len = nums.Length;
        int[] result = new int[len*2];
        
        for(int i = 0; i < len; i++){
            result[i] = nums[i];
            result[i+len] = nums[i];
        }
        
        return result;
    }
}