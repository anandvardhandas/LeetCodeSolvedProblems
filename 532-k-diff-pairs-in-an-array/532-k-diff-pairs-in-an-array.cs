public class Solution {
    public int FindPairs(int[] nums, int k) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        int total = 0;
        for(int i = 0; i < nums.Length; i++){
            //check if this number existed before
            if(!map.ContainsKey(nums[i])){
                //check for left
                if(map.ContainsKey(nums[i]-k)){
                    total++;
                }
                //check for right
                if(map.ContainsKey(nums[i]+k)){
                    total++;
                }
                
                map.Add(nums[i], 1);
            }
            else{
                if(k == 0 && map[nums[i]] != 0){
                    total++;
                    map[nums[i]] = 0;
                }
            }
        }
        
        return total;
    }
}