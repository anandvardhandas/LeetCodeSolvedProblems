public class Solution {
    public int[] FindOriginalArray(int[] changed) {
        //0,1,3,6
        int len = changed.Length;
        
        if(len%2 == 1)
            return new int[0];
        
        int[] result = new int[len/2];
        
        Array.Sort(changed);
        int index = 0;
        
        for(int i = 0; i < len; i++){
            if(changed[i] != -1){
                if(index == result.Length)
                    return new int[0];
                
                FindAndUpdateNextDouble(changed, changed[i]*2, i+1, len-1);
                result[index++] = changed[i]; 
            }
        }
        
        return result;
    }
    
    private void FindAndUpdateNextDouble(int[] nums, int num, int low, int hi){
        if(low < nums.Length && hi < nums.Length){
            while(hi < nums.Length && low <= hi){
                int mid = low + (hi-low)/2;
                if(num > nums[mid]){
                    low = mid+1;
                }
                else if(num <= nums[mid]){
                    hi = mid-1;
                }
            }
            
            if(low < nums.Length && nums[low] == num)
                nums[low] = -1;
        }
    }
}