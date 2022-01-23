public class Solution {
    public IList<int> FindLonely(int[] nums) {
        int len = nums.Length;
        IList<int> result = new List<int>();
        Array.Sort(nums);
        //1,4,4,4,5,6,9,10,12,13,15  -> 1,15
        for(int i = 0; i < len; i++){
            if(i < len-1 && nums[i] == nums[i+1]){
                while(i < len-1 && nums[i] == nums[i+1]){
                    i++;
                }
            }
            else if(i < len-1 && nums[i] + 1 == nums[i+1])
                continue;
            else if(i > 0 && nums[i] - 1 == nums[i-1])
                continue;
            else
                result.Add(nums[i]);
        }
        
        return result;
    }
}