public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums); //-4,-1,-1,0,1,2
        IList<IList<int>> result = new List<IList<int>>();
        
        int len = nums.Length;
        int i = 0;
        while(i <= len-3){
            if(i == 0 || (i > 0 && nums[i] != nums[i-1])){
                int j = i+1, k = len-1;
               
                while(j < k){
                    int sum = nums[i]+nums[j]+nums[k];
                    if(sum == 0){
                        result.Add(new List<int>() { nums[i], nums[j], nums[k] });
                        while(j < k && nums[j] == nums[j+1]){
                            j++;
                        }

                        while(k > j && nums[k] == nums[k-1]){
                            k--;
                        }

                        j++;
                        k--;
                    }
                    else if(sum < 0){
                        j++;
                    }
                    else if(sum > 0){
                        k--;
                    }
                }
            }
            
            i++;
        }
        
        return result;
    }
}