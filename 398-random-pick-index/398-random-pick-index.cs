public class Solution {
    private int[] map;
    private Random random;
    public Solution(int[] nums) {
        map = nums;
        random = new Random();
    }
    
    public int Pick(int target) {
        int count = 0;
        int result = 0;
        for(int i = 0; i < map.Length; i++){
            if(map[i] == target){
                count++;
                int rand = random.Next(1, count+1);
                if(rand == 1){
                    result = i;
                }
            }
        }
        
        return result;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int param_1 = obj.Pick(target);
 */