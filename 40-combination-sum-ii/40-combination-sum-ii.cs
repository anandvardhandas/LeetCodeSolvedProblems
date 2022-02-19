public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
       IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(candidates);
        Helper(candidates,result,new List<int>(), target, target, 0);
        return result;
    }
    
    //1,1,2,5,6,7,10
    private void Helper(int[] nums, IList<IList<int>> result, IList<int> temp, int actual, int target, int index){
        if(target == 0){
            result.Add(new List<int>(temp));
            return;
        }
        
        if(target < 0 || index == nums.Length){
            return;
        }
        
        for(int i = index; i < nums.Length; i++){
            if(i > 0 && nums[i] == nums[i-1] && i > index)
                continue;
            
            temp.Add(nums[i]);
            Helper(nums, result, temp, actual, target - nums[i], i+1);
            temp.RemoveAt(temp.Count-1);
        }
    }
}