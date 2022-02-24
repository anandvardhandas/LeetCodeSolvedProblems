public class Solution {
    public int DeleteAndEarn(int[] nums) {
        SortedDictionary<int,int> map = new SortedDictionary<int,int>();
        foreach(int num in nums){
            if(!map.ContainsKey(num)){
                map.Add(num,num);
            }
            else{
                map[num] += num;
            }
        }
        
        int[] arr = new int[map.Count];
        int index = 0;
        foreach(var item in map){
            arr[index++] = item.Key;
        }
        
        int[] dp = new int[map.Count+1];
        
        return Helper(map, arr, 0, dp);
    }
    
    
    private int Helper(SortedDictionary<int,int> map, int[] arr, int index, int[] dp){
        if(index >= map.Count){
            return 0;
        }
        
        if(dp[index] > 0){
            return dp[index];
        }
        
        //take the current value and take next value or skip based on condition that next value is +1 than current value
        int res1 = 0, res2 = 0;
        if(index < map.Count-1 && arr[index] != arr[index+1]-1){
            res1 = map[arr[index]] + Helper(map, arr, index+1, dp);
        }
        //skip the current value and take the next value
        else{
            res1 = map[arr[index]] + Helper(map, arr, index+2, dp);
        }
        
        res2 = Helper(map, arr, index+1, dp);
        int result = Math.Max(res1, res2);
        
        dp[index] = result;
        return result;
    }
}