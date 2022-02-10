class Solution {
    public int subarraySum(int[] nums, int k) {
        int len = nums.length;
        int[] prefixsum = new int[len];
        prefixsum[0] = nums[0];
        
        for(int i = 1; i < len; i++){
            prefixsum[i] = nums[i] + prefixsum[i-1];
        }
        
        HashMap<Integer,Integer> map = new HashMap<>();
        map.put(0,1);
        
        int result = 0;
        for(int i = 0; i < len; i++){
            int num = prefixsum[i]-k;
            if(map.containsKey(num)){
                result = result + map.get(num);
            }
            
            if(map.containsKey(prefixsum[i])){
                map.put(prefixsum[i], map.get(prefixsum[i])+1);
            }
            else{
                map.put(prefixsum[i],1);
            }
        }
        
        return result;
    }
}