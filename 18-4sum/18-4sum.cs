public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        int len = nums.Length;
        IList<IList<int>> result = new List<IList<int>>();
        if(len < 4)
            return result;
        
        Array.Sort(nums);
        //-2,-2,-1,0,0,1
        int i = 0;
        while(i <= len-4){
            int j = i+1;
            while(j <= len-3){
                int low = j+1, hi = len-1;
                while(low < hi){
                    int sum = nums[i] + nums[j] + nums[low] + nums[hi];
                    if(sum < target){
                        low++;
                    }
                    else if(sum > target){
                        hi--;
                    }
                    else{
                        result.Add(new List<int>() { nums[i], nums[j], nums[low], nums[hi] });
                        while(low < hi && nums[low] == nums[low+1]){
                            low++;
                        }
                        
                        while(hi > low && nums[hi] == nums[hi-1]){
                            hi--;
                        }
                        
                        low++;
                        hi--;
                    }
                }
                
                while(j < len-3 && nums[j] == nums[j+1]) j++;
                
                j++;
            }
            
            while(i < len-4 && nums[i] == nums[i+1]) i++;
            
            i++;
        }
        
        return result;
    }
}