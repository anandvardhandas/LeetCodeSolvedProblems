public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int len = nums.Length;
        
        for(int index = 0; index < len; index++){
            if(nums[index] < 0){
                nums[index] = -1;
            }
        }
        
        int i = 0;
        while(i < len){
            if(nums[i] != int.MinValue && nums[i] > 0){
                int j = nums[i]-1;
                while(j >= 0 && j < len && nums[j] != int.MinValue){
                    int temp = nums[j]-1;
                    nums[j] = int.MinValue;
                    j = temp;
                }
            }
            else if(nums[i] != int.MinValue){
                nums[i] = 0;
            }
            
            i++;
        }
        
        for(int k = 0; k < len; k++){
            if(nums[k] >= 0){
                return k+1;
            }
        }
        
        return len+1;
    }
}