public class Solution {
    public int GetMinDistance(int[] nums, int target, int start) {
        
        int l = start, r = start;
        while(true){
            if(l >= 0){
                if(nums[l] == target){
                    return Math.Abs(l-start);
                }
                
                l--;
            }
            
            if(r < nums.Length){
                if(nums[r] == target){
                    return Math.Abs(r-start);
                }
                
                r++;
            }
        }
        
        return -1;
    }
}