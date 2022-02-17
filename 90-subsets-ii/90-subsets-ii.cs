public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        IList<IList<int>> result = new List<IList<int>>();
        Helper(nums, result, new List<int>(), 0);
        return result;
    }
    
    //1,2,2 -> [], [1], [1,2], []
    private void Helper(int[] nums, IList<IList<int>> result, IList<int> temp, int index){
        result.Add(new List<int>(temp));
        
        if(index == nums.Length){
            return;
        }
        
        for(int i = index; i < nums.Length; i++){
            if(i == index || (i > index && nums[i] != nums[i-1])){
                temp.Add(nums[i]);
                Helper(nums, result, temp, i+1);
                temp.RemoveAt(temp.Count-1);
            }
        }
    }
}