public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        //result.Add(new List<int>());
        
        Helper(nums, result, new List<int>(), 0);
        
        return result;
    }
    
    //1,2,3,4,5,6
    private void Helper(int[] nums, IList<IList<int>> result, List<int> temp, int index){
        result.Add(new List<int>(temp));
        
        if(index == nums.Length)
            return;
        
        for(int i = index; i < nums.Length; i++){
            temp.Add(nums[i]);
            Helper(nums, result, temp, i+1);
            temp.RemoveAt(temp.Count-1);
        }
    }
}