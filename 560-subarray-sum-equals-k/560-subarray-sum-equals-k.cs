public class Solution {
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        map.Add(0,1);
        
        int len = nums.Length;
        
        int[] prefix = new int[len];
        prefix[0] = nums[0];
        
        //[2,1,-2,2,1] k = 3
        //[2,3,1,3,4]
        //[1,1,1] k = 2
        //[1,2,3]
        int total = 0;
        for(int i = 0; i < len; i++){
            if(i > 0){
                prefix[i] = prefix[i-1]+nums[i];
            }
            if(map.ContainsKey(prefix[i]-k)){
                //Console.WriteLine(i);
                total += map[prefix[i]-k];
            }
            
            if(!map.ContainsKey(prefix[i])){
                map.Add(prefix[i],1);
            }
            else{
                map[prefix[i]]++;
            }
        }
        
        return total;
        
    }
}