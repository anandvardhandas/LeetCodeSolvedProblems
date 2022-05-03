public class Solution {
    public int MissingElement(int[] nums, int k) {
        int len = nums.Length;
        
        int missing = nums[len-1]-nums[0]-(len-1);
        if(missing < k){
            return nums[len-1]+k-missing;
        }
        
        int low = 0, hi = len-1;
        while(low < hi){
            if(low == hi-1)
                break;
            
            int mid = low + (hi-low)/2;
            int diff = nums[mid]-nums[low]-(mid-low);
            if(diff >= k){
                hi = mid;
            }
            else{
                k = k-diff;
                low = mid;
            }
        }
        
        return nums[low]+k;
    }
}