class Solution {
    public int findPairs(int[] nums, int k) {
        HashMap<Integer,Integer> map = new HashMap<Integer,Integer>();
        int total = 0;
        for(int i = 0; i < nums.length; i++){
            //check if this number existed before
            if(!map.containsKey(nums[i])){
                //check for left
                if(map.containsKey(nums[i]-k)){
                    total++;
                }
                //check for right
                if(map.containsKey(nums[i]+k)){
                    total++;
                }
                
                map.put(nums[i], 1);
            }
            else{
                if(k == 0 && map.get(nums[i]) != 0){
                    total++;
                    map.put(nums[i], 0);
                }
            }
        }
        
        return total;
    }
}