public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        int len = nums.Length;
        IList<string> result = new List<string>();
        if(len == 0)
            return result;
        
        List<string> list = new List<string>();
        int low = 0, hi = 0;
        while(low < len){
            list = new List<string>();
            list.Add(nums[low].ToString());
            hi = low;
            while(hi < len-1 && nums[hi] == nums[hi+1]-1){
                hi++;
            }
            
            if(hi > low){
                list.Add("->");
                list.Add(nums[hi].ToString());
            }
            
            result.Add(string.Join("", list));
            
            low = hi+1;
        }
        
        return result;
    }
}