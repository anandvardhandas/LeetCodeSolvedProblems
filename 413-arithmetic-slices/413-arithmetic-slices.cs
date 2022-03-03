public class Solution {
    public int NumberOfArithmeticSlices(int[] nums) {
        int len = nums.Length;
        int i = 1;
        int prev = int.MaxValue;
        int count = 0;
        int total = 0;
        while(i < len){
            if(nums[i]-nums[i-1] == prev){
                count++;
                total += count;
            }
            else{
                prev = nums[i] - nums[i-1];
                count = 0;
            }
            
            i++;
        }
        
        return total;
    }
}