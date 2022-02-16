class Solution {
    public int[] findOriginalArray(int[] changed) {
       //0,1,3,6
        int len = changed.length;
        
        if(len%2 == 1)
            return new int[0];
        
        int[] result = new int[len/2];
        
        Arrays.sort(changed);
        int index = 0;
        
        for(int i = 0; i < len; i++){
            if(changed[i] != -1){
                if(index == result.length)
                    return new int[0];
                
                FindAndUpdateNextDouble(changed, changed[i]*2, i+1, len-1);
                result[index++] = changed[i]; 
            }
        }
        
        return result;
    }
    
    private void FindAndUpdateNextDouble(int[] nums, int num, int low, int hi){
        if(low < nums.length && hi < nums.length){
            while(hi < nums.length && low <= hi){
                int mid = low + (hi-low)/2;
                if(num > nums[mid]){
                    low = mid+1;
                }
                else if(num <= nums[mid]){
                    hi = mid-1;
                }
            }
            
            if(low < nums.length && nums[low] == num)
                nums[low] = -1;
        }
    }
}