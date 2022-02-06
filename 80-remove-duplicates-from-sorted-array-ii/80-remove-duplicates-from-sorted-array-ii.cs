public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int len = nums.Length;
        
        int prev = nums[0], prevCount = 1;
        int leftIndex = 1;
        for(int i = 1; i < len; i++){
            if(nums[i] == prev){
                if(prevCount < 2){
                    nums[leftIndex] = nums[i];
                    prevCount++;
                    leftIndex++;
                }
                else{
                    prevCount++;
                }
            }
            else{
                prevCount = 1;
                nums[leftIndex] = nums[i];
                leftIndex++;
                prev = nums[i];
            }
            
        }
        
        return leftIndex;
    }
}