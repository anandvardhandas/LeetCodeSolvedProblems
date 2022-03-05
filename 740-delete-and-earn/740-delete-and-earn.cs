public class Solution {
    public int DeleteAndEarn(int[] nums) {
        int len = nums.Length;
        SortedDictionary<int,int> map = new SortedDictionary<int,int>();
        for(int i = 0; i < len; i++){
            if(!map.ContainsKey(nums[i])){
                map.Add(nums[i], nums[i]);
            }
            else{
                map[nums[i]] += nums[i];
            }
        }
        
        int[] arr = new int[map.Count];
        int index = 0;
        foreach(var item in map){
            arr[index++] = item.Key;
        }
        
        int[] dp = new int[arr.Length+1];
        return Helper(arr, map, 0, dp);
    }
    
    private int Helper(int[] arr, SortedDictionary<int,int> map, int index, int[] dp){
        if(index >= arr.Length)
            return 0;
        
        if(dp[index] > 0)
            return dp[index];
        
        int sum1 = map[arr[index]];
        int sum2 = 0;
        if(index < arr.Length-1 && arr[index] != arr[index+1]-1){
            sum1 += Helper(arr, map, index+1, dp);
        }
        else{
            sum1 += Helper(arr, map, index+2, dp);
        }
        
        sum2 = Helper(arr, map, index+1, dp);
        
        int result = Math.Max(sum1, sum2);
        dp[index] = result;
        return result;
    }
}