public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        Array.Sort(candidates);
        IList<IList<int>> result = new List<IList<int>>();
        Helper(candidates, result, new List<int>(), target, 0);
        return result;
    }
    
    private void Helper(int[] nums, IList<IList<int>> result, IList<int> temp, int target, int index){
        if(target == 0 && index <= nums.Length){
            result.Add(new List<int>(temp));
            return;
        }
        
        if(target < 0 || index == nums.Length){
            return;
        }
        
        for(int i = index; i < nums.Length; i++){
            temp.Add(nums[i]);
            Helper(nums, result, temp, target-nums[i], i);
            temp.RemoveAt(temp.Count-1);
        }
    }
}