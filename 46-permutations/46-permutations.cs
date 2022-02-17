public class Solution {
    private Dictionary<int,int> map = new Dictionary<int,int>();
    public IList<IList<int>> Permute(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        Helper(nums, result);
        return result;
    }
    
    
    //1,2,3,4 [1,2,3,4],[1,2,4,3],[1,3,2,4],[1,3,4,2],[1,4,2,3],[1,4,3,2]
    private void Helper(int[] nums, IList<IList<int>> result){
        if(map.Count == nums.Length){
            result.Add(map.Keys.ToList());
            return;
        }
        
        for(int i = 0; i < nums.Length; i++){
            if(!map.ContainsKey(nums[i])){
                map.Add(nums[i],nums[i]);
                Helper(nums, result);
                map.Remove(nums[i]);
            }
        }
    }
}