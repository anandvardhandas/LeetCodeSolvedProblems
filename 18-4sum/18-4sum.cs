public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        IList<IList<int>> result = new List<IList<int>>();
        
        Array.Sort(nums);
        int len = nums.Length;
        //-2,-1,0,0,1,2
        //-2,-2,-2,-1,0,0,1,2
        //-2,-1,0,0,1,2
        for(int i = 0; i <= nums.Length-4; i++){
            if(i > 0 && nums[i] == nums[i-1])
                continue;
           
            for(int j = i+1; j <= nums.Length-3; j++){
                if(j > i+1 && nums[j] == nums[j-1])
                    continue;
                
                int low = j+1, hi = len-1;
                int sum = nums[i] + nums[j];
                while(low < hi){
                    if(sum+nums[low]+nums[hi] == target){
                        result.Add(new List<int>() { nums[i], nums[j], nums[low], nums[hi] });

                        while(low < len-1 && nums[low] == nums[low+1]){
                            low++;
                        }

                        while(hi > j+1 && nums[hi] == nums[hi-1]){
                            hi--;
                        }

                        low++;
                        hi--;

                    }
                    else if(sum+nums[low]+nums[hi] < target){
                        low++;
                    }
                    else if(sum+nums[low]+nums[hi] > target){
                        hi--;
                    }
                }
            }
        }
        
        return result;
    }
}