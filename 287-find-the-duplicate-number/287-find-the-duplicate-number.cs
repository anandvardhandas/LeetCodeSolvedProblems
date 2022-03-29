public class Solution {
    public int FindDuplicate(int[] nums) {
        int len = nums.Length;
        
        int low = 1, hi = len-1;//not indexes but consider it as min and max values in range 
        int duplicate = -1;
        while(low <= hi){
            int mid = (low+hi)/2;
            
            //count how many below or equal to mid
            int count = 0;
            foreach(int num in nums){
                if(num <= mid)
                    count++;
            }
            
            if(count > mid){
                hi = mid-1;
                duplicate = mid;
            }
            else{
                low = mid+1;
            }
        }
        
        return duplicate;
    }
}