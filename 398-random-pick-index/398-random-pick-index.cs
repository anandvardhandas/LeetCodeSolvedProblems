public class Solution {
    private Dictionary<int,List<int>> map;
    public Solution(int[] nums) {
        map = new Dictionary<int,List<int>>();
        for(int i = 0; i < nums.Length; i++){
            if(map.ContainsKey(nums[i])){
                map[nums[i]].Add(i);
            }
            else{
                map.Add(nums[i], new List<int>() { i });
            }
        }
    }
    
    public int Pick(int target) {
        List<int> list = map[target];
        int rand = new Random().Next(0, list.Count);
        return list[rand];
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int param_1 = obj.Pick(target);
 */