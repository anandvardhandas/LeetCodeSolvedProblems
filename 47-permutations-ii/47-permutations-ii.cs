public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        int len = nums.Length;
        Array.Sort(nums);
        IList<IList<int>> result = new List<IList<int>>();
        bool[] used = new bool[len];
        Helper(nums, result, new List<int>(), used);
        return result;
    }
    
    
    private void Helper(int[] nums, IList<IList<int>> result, IList<int> temp, bool[] used){
        if(temp.Count == nums.Length){
            result.Add(new List<int>(temp));
            return;
        }
        
        for(int i = 0; i < nums.Length; i++){
            if(used[i] == false && (i == 0 || ( i > 0 && (nums[i] != nums[i-1] || (nums[i] == nums[i-1] && used[i-1] == true))))){
                used[i] = true;
                temp.Add(nums[i]);
                Helper(nums, result, temp, used);
                temp.RemoveAt(temp.Count-1);
                used[i] = false;
            }
        }
    }
}