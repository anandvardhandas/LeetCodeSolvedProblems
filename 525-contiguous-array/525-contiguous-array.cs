public class Solution {
    public int FindMaxLength(int[] nums) {
        //1,0,0,0,1,0,1,1,0,0,0,0,1,1,1,1,1,0,1
        //-1,1,1,-1,-1,-1,-1,1,1,1,1,1,-1,1
        //-1,0,1,0,-1,-2,-3,-2,-1,0,1,2,1,2
        
        //1,1,1,1,1,1,1,0,0,0,1,1,1,1,1,1,1,1
        //1,1,1,1,1,1,1,-1,-1,-1,1,1,1,1,1,1,1,1
        //1,2,3,4,5,6,7,6,5,4,5,6,7,8,9,10,11,12
        
        //0,0,1
        //-1,-1,1
        //-1,-2,-1
        int len = nums.Length;
        
        int maxLen = 0;
        //replace all zeros by -1
        for(int i = 0; i < len; i++){
            if(nums[i] == 0)
                nums[i] = -1;
        }
        
        //calculate prefix sum and keep storing in hashmap and check for the same if found, calculate length and update the maxlen
        Dictionary<int,int> map = new Dictionary<int,int>();
        map.Add(nums[0], 0);
        for(int i = 1; i < len; i++){
            nums[i] = nums[i] + nums[i-1];
            if(nums[i] == 0){
                maxLen = i+1;
            }
            else{
                if(!map.ContainsKey(nums[i])){
                    map.Add(nums[i], i);
                }
                else{
                    if(i-map[nums[i]] > maxLen)
                        maxLen = i-map[nums[i]];
                }
            }
            
        }
        
        return maxLen;
        
    }
}