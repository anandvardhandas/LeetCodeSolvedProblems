public class Solution {
    public IList<string> FindMissingRanges(int[] nums, int lower, int upper) {
        int len = nums.Length;
        IList<string> result = new List<string>();
        if(len == 0){
            result.Add(Helper(lower,upper));
            return result;
        }
        
        //prev range than first number
        if(nums[0] > lower){
            result.Add(Helper(lower,nums[0]-1));
        }
        
        //current range
        for(int i = 0; i < len-1; i++){
            if(nums[i+1]-nums[i] > 1){
                result.Add(Helper(nums[i]+1,nums[i+1]-1));
            }
        }
        
        //last range
        if(upper-nums[len-1] > 0){
            result.Add(Helper(nums[len-1]+1,upper));
        }
        
        return result;
        
    }
    
    private string Helper(int lower, int upper){
        if(lower == upper)
            return $"{lower}";
        else
            return $"{lower}->{upper}";
    }
}