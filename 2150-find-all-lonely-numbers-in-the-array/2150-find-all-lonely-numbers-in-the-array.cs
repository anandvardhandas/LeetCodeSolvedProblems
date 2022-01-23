public class Solution {
    public IList<int> FindLonely(int[] nums) {
        int len = nums.Length;
        IList<int> result = new List<int>();
        //Array.Sort(nums);
        //1,4,4,4,5,6,9,10,12,13,15  -> 1,15
        Dictionary<int,int> map = new Dictionary<int,int>();
        
        for(int i = 0; i < len; i++){
            if(map.ContainsKey(nums[i] + 1)){
                map[nums[i]+1]++;
                if(map.ContainsKey(nums[i]))
                    map[nums[i]]++;
                else{
                    map.Add(nums[i],2);
                }
            }
            
            if(map.ContainsKey(nums[i] - 1)){
                map[nums[i]-1]++;
                if(map.ContainsKey(nums[i]))
                    map[nums[i]]++;
                else{
                    map.Add(nums[i],2);
                }
            }
            
            if(map.ContainsKey(nums[i])){
                map[nums[i]]++;
            }
            else{
                map.Add(nums[i], 1);
            }
        }
                    
          foreach(var item in map){
              if(item.Value == 1)
                result.Add(item.Key);
          }          
        
        return result;
    }
}