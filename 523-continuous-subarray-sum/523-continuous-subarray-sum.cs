public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        // 23, 2, 4, 6, 7
        // 23, 25, 29, 35, 42
        
        Dictionary<int,int> map = new Dictionary<int,int>();
        
        int total = 0;
        
        map.Add(0, -1);
        for(int i = 0; i < nums.Length; i++){
            total += nums[i];
            
            int rem = total%k;
            
            if(map.ContainsKey(rem)){
                int index = map[rem];
                
                if(i-index > 1){
                    return true;
                }
            }
            else{
                map.Add(rem, i);
            }
        }
        
        return false;
        
    }
}