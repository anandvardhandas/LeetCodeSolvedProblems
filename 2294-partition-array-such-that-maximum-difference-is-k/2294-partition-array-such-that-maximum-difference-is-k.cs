public class Solution {
    public int PartitionArray(int[] nums, int k) {
        //[3,6,1,2,5]
        //1,2,3,5,6
        
        Array.Sort(nums);
        int count = 1;
        int min = nums[0];
        for(int i = 1; i < nums.Length; i++){
            if(nums[i]-min <= k){
                continue;
            }
            else{
                count++;
                min = nums[i];
            }
        }
        
        return count;
    }
}