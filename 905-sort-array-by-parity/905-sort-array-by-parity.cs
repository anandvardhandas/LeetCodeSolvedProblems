public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        int len = nums.Length;
        int low = 0, hi = len-1;
        
        while(low < hi){
            if(nums[hi]%2 == 0 && nums[low]%2 == 1){
                Swap(nums, hi, low);
                low++;
                hi--;
            }
            else if(nums[hi]%2 == 0 && nums[low]%2 == 0){
                low++;
            }
            else if(nums[hi]%2 == 1 && nums[low]%2 == 1){
                hi--;
            }
            else{
                low++;
                hi--;
            }
        }
        
        return nums;
    }
    
    private void Swap(int[] nums, int x, int y){
        int temp = nums[x];
        nums[x] = nums[y];
        nums[y] = temp;
    }
}