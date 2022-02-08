class Solution {
    public void nextPermutation(int[] nums) {
        //39845  
        //approach would be to find from last where the number is decreasing and then find the next greater number from that number
        int len = nums.length;
        int i = len-1;
        while(i > 0 && nums[i] <= nums[i-1]){
            i--;
        }
        
        //means array is reversed so just reverse it and return
        if(i == 0){
            int j = 0, k = len-1;
            while(j <= k){
                //Swap
                Swap(nums, j, k);
                j++;
                k--;
            }
             return;
        }
        
        //find the next highest number than i-1 th number
        int l = i;
        int nextHighest = l++;
        while(l < len){
            if(nums[l] > nums[i-1] && nums[l] <= nums[nextHighest])
                nextHighest = l;
            
            l++;
        }
        
        Swap(nums, i-1, nextHighest);
        
        //As numbers are already sorted on right side, we just need to reverse from ith position to len-1
        Reverse(nums, i, len-1);
        
    }
    
    private void Reverse(int[] nums, int low, int hi){
        while(low < hi){
            Swap(nums, low, hi);
            low++;
            hi--;
        }
    }
    
    private void Swap(int[] nums, int i, int j){
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}