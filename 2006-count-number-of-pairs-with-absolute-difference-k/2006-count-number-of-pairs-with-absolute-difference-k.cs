public class Solution {
    public int CountKDifference(int[] nums, int k) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        int total = 0;
        for(int i = 0; i < nums.Length; i++){
            if(map.ContainsKey(nums[i]+k)){
                total += map[nums[i]+k];
            }
            
            if(map.ContainsKey(nums[i]-k)){
                total += map[nums[i]-k];
            }
            
            if(map.ContainsKey(nums[i])){
                map[nums[i]]++;
            }
            else{
                map.Add(nums[i],1);
            }
        }
        
        return total;
    }
}