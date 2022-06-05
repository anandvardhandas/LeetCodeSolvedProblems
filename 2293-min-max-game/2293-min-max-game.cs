public class Solution {
    public int MinMaxGame(int[] nums) {
        while(true){
            if(nums.Length == 1)
                break;
            int[] nnums = new int[nums.Length/2];
            for(int i = 0; i < nnums.Length; i++){
                if(i%2 == 1){
                    nnums[i] = Math.Max(nums[2 * i], nums[2 * i + 1]);
                }
                else{
                    nnums[i] = Math.Min(nums[2 * i], nums[2 * i + 1]);
                }
            }
            
            nums = nnums;
        }
        
        return nums[0];
    }
}