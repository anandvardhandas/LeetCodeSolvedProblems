public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        List<int> result = new List<int>();
        int len = nums.Length;
        if(k > len)
            return result.ToArray();
        
        int l = 0, r = 0;
        LinkedList<int> que = new LinkedList<int>();
        while(r < len){
            //remove all numbers smaller than rth number
            while(que.Count > 0 && nums[r] >= nums[que.Last.Value]){
                que.RemoveLast();
            }
            
            que.AddLast(r);
            
            // set l
            l = r - k + 1;
            
            if(que.First.Value < l){
                que.RemoveFirst();
            }
            
            if(l >= 0){
                result.Add(nums[que.First.Value]);
            }
            
            r++;
        }
        
        
        return result.ToArray();
    }
}