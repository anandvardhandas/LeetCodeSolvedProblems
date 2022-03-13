public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length;
        
        int expectedSum = (n * (n+1))/2;
        int actualSum = 0;
        for(int i = 0; i < nums.Length; i++){
            actualSum += nums[i];
        }
        
        return expectedSum-actualSum;
    }
}