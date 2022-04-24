public class Solution {
    public IList<string> FindMissingRanges(int[] nums, int lower, int upper) {
        IList<string> result = new List<string>();
        if(lower == upper){
            if(nums.Length == 0)
                result.Add($"{lower}");
            
            return result;
        }
        
        if(nums.Length == 0){
            result.Add($"{lower}->{upper}");
            return result;
        }
        
        int prev = lower;
        for(int i = 0; i < nums.Length; i++){
            if(i == 0 && nums[i] > prev){
                int l = prev;
                int r = nums[i]-1;
                if(l == r){
                    result.Add($"{l}");
                }
                else{
                    result.Add($"{l}->{r}");
                }
                
                prev = nums[i];
            }
            
            if(nums[i] > prev+1){
                int l = prev+1;
                int r = nums[i]-1;
                if(l == r){
                    result.Add($"{l}");
                }
                else{
                    result.Add($"{l}->{r}");
                }
            }
            
            prev = nums[i];
        }
        
        if(prev < upper){
            if(prev+1 == upper){
                result.Add($"{upper}");
            }
            else{
                result.Add($"{prev+1}->{upper}");
            }
        }
        
        return result;
    }
}