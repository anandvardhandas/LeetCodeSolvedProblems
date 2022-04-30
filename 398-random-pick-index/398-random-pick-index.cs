public class Solution {
    private int[] nums;
    private Random random;
    public Solution(int[] nums) {
        this.nums = nums;
        this.random = new Random();
    }
    
    public int Pick(int target) {
        
        int index = 0;
        int count = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] == target){
                count++;
                
                int rand = random.Next(0,count);
                if(rand == 0){
                    index = i;
                }
            }
        }
        
        return index;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int param_1 = obj.Pick(target);
 */