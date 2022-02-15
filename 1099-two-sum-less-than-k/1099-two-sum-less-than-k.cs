public class Solution {
    public int TwoSumLessThanK(int[] nums, int k) {
        Array.Sort(nums);
        int low = 0, hi = nums.Length-1;
        int maxSum = -1;
        while(low < hi){
            int currSum = nums[low] + nums[hi];
            if(currSum >= k){
                hi--;
            }
            else{
                maxSum = Math.Max(maxSum, currSum);
                low++;
            }
        }
        
        return maxSum;
    }
}