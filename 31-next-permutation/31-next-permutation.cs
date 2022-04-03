public class Solution {
    public void NextPermutation(int[] nums) {
        
        int len = nums.Length;
        
        int i = len-1;
        while(i > 0 && nums[i] <= nums[i-1]){
            i--;
        }
        
        if(i == 0){
            Array.Sort(nums);
            return;
        }
        
        //Find next greater number of i-1
        int num = nums[i-1];
        int nextgreater = i;
        for(int j = i+1; j < len; j++){
            if(nums[j] < nums[nextgreater] && nums[j] > num){
                nextgreater = j;
            }
        }
        
        Swap(nums, i-1, nextgreater);
        
        Sort(nums, i, len-1);
    }
    
    private void Sort(int[] nums, int l, int r){
        if(l < r){
            int pindex = Partition(nums, l, r);
            Sort(nums, l, pindex-1);
            Sort(nums, pindex+1, r);
        }
    }
    
    private int Partition(int[] nums, int l, int r){
        int i = l;
        
        for(int j = l; j < r; j++){
            if(nums[j] <= nums[r]){
                Swap(nums, j, i);
                i++;
            }
        }
        
        Swap(nums, i, r);
        return i;
    }
    
    private void Swap(int[] nums, int i, int j){
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}