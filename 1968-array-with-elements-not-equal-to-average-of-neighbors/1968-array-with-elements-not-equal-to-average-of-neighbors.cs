public class Solution {
    public int[] RearrangeArray(int[] nums) {
        int len = nums.Length;
        
        for(int i = len-2; i >= 1; i--){
            if((nums[i-1]+nums[i+1])/2 == nums[i]){
                Swap(nums, i, i+1);
            }
        }
        
        for(int i = 1; i <= len-2; i++){
            if((nums[i-1]+nums[i+1])/2 == nums[i]){
                Swap(nums, i, i+1);
            }
        }
        
        return nums;
    }
    
    private void Swap(int[] nums, int i, int j){
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}