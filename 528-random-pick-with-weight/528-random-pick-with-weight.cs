public class Solution {
    private int[][] nums;
    int prevsum = 0;
    public Solution(int[] w) {
        nums = new int[w.Length][];
        
        for(int i = 0; i < w.Length; i++){
            nums[i] = new int[] { prevsum+1, prevsum+w[i] };
            prevsum += w[i];
        }
    }
    
    public int PickIndex() {
        int rand = new Random().Next(1, prevsum+1);
        //binary search
        int l = 0, r = nums.Length-1;
        while(l <= r){
            int mid = l + (r-l)/ 2;
            if(rand >= nums[mid][0] && rand <= nums[mid][1]){
                return mid;
            }
            else if(rand > nums[mid][1]) {
                l = mid+1;
            }
            else if(rand < nums[mid][0]){
                r = mid-1;
            }
        }
        
        return l;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(w);
 * int param_1 = obj.PickIndex();
 */