class Solution {
    public List<List<Integer>> subsets(int[] nums) {
        List<List<Integer>> result = new ArrayList();
        Helper(nums, result, new ArrayList(), 0);
        return result;
    }
    
    private void Helper(int[] nums, List<List<Integer>> result, List<Integer> temp, int index){
        result.add(new ArrayList(temp));
        
        if(index == nums.length)
            return;
        
        for(int i = index; i < nums.length; i++){
            temp.add(nums[i]);
            Helper(nums, result, temp, i+1);
            temp.remove(temp.size()-1);
        }
    }
}