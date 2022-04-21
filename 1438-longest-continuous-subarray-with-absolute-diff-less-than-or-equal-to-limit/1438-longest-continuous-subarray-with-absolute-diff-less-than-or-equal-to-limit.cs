public class Solution {
    public int LongestSubarray(int[] nums, int limit) {
        int len = nums.Length;
        int l = 0, r = 0;
        int result = 1;
        LinkedList<int> maxque = new LinkedList<int>();
        LinkedList<int> minque = new LinkedList<int>();
        while(r < len){
            while(maxque.Count > 0 && nums[r] >= nums[maxque.Last.Value]){
                maxque.RemoveLast();
            }
            maxque.AddLast(r);
            
            while(minque.Count > 0 && nums[r] <= nums[minque.Last.Value]){
                minque.RemoveLast();
            }
            minque.AddLast(r);
            
            while(nums[maxque.First.Value] - nums[minque.First.Value] > limit){
                l++;
                
                if(maxque.First.Value < l){
                    maxque.RemoveFirst();
                }
                
                if(minque.First.Value < l){
                    minque.RemoveFirst();
                }
            }
            
            result = Math.Max(result, r-l+1);
            
            r++;
        }
        
        return result;
    }
}