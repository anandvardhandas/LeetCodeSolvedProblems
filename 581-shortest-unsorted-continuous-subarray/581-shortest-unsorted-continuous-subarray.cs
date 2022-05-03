public class Solution {
    public int FindUnsortedSubarray(int[] nums) {
        int len = nums.Length;
        
        
        //look for first decreasing number
        int lowest = int.MaxValue;
        for(int i = 0; i < len-1; i++){
            if(nums[i] > nums[i+1]){
                lowest = Math.Min(lowest, nums[i+1]);
            }
        }
        
        
        //look for first increasing number from right
        int highest = int.MinValue;
        for(int i = len-1; i > 0; i--){
            if(nums[i] < nums[i-1]){
                highest = Math.Max(highest, nums[i-1]);
            }
        }
        
        if(lowest == int.MaxValue && highest == int.MinValue)
            return 0;
        
        //find the correct position of lowest
        int left = -1;
        for(int i = 0; i < len; i++){
            if(lowest < nums[i]){
                left = i;
                break;
            }
        }
        
        //find the correct position of highest
        int right = -1;
        for(int i = len-1; i >= 0; i--){
            if(highest > nums[i]){
                right = i;
                break;
            }
        }
        
        return right-left+1;
    }
}