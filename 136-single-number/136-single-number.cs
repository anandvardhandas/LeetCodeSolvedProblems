public class Solution {
    public int SingleNumber(int[] nums) {
        int ans = nums[0];
        for(int i = 1; i < nums.Length; i++){
            ans = ans ^ nums[i];
        }
        
        return ans;
    }
}