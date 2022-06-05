public class Solution {
    public int[] ArrayChange(int[] nums, int[][] operations) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++){
            map.Add(nums[i], i);
        }
        
        for(int i = 0; i < operations.Length; i++){
            int index = map[operations[i][0]];
            map.Remove(operations[i][0]);
            nums[index] = operations[i][1];
            map.Add(operations[i][1], index);
        }
        
        return nums;
    }
}